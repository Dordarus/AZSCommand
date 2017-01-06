using System;
using System.Linq;
using System.Windows.Forms;
using AZSCommand.Properties;

namespace AZSCommand
{
    public partial class Form5 : Form
    {
        private readonly Form1 _f1;

        public Form5(Form1 f)
        {
            InitializeComponent();
            _f1 = f;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var context = new NutshellContext();

            context.ExecuteCommand("DELETE FROM Restock");

            restockTableAdapter.Fill(aZSCommandDataSet.Restock);
            fuelTableAdapter.Fill(aZSCommandDataSet.Fuel);

            ComboBoxFiller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTools my = new MyTools();

            //Викликаю клас-конструктор таблиць
            var context = new NutshellContext();

            // Після внесення змін в талицю через DataGridView зберегти їх у DataSet
            restockTableAdapter.Update(aZSCommandDataSet);
            fuelTableAdapter.Update(aZSCommandDataSet);

            //Запит на ті види палива, що були поповненні
            var query = context.Restock
                .Where(c => c.Поповнити_у_кількості != null);

            /* Цикл пробігає по переданій запитом таблиці та проходить по Виду палива, що був поповнений.
             * Наступний запит "name" шукає у талиці з Поточною кількістю палива спочатку ту Паливну станцію
             * котру обрав користувач у ComboBox, після того як коло потрібних сутностей зменшилось переходимо 
             * до тільки того виду палива котрий був попонений, далі цикл вибирає перший Вид палива передає його на 
             * порівняння на співадіння, якщо співпадіння у даній Паливній станції за цим Видом палива знайдено, то
             * я переписую комріку Поточного об'єму, на суму його самого та результату запиту по співпадінню цього самого 
             * виду палива у таблиці Поставки(Restock) та за цим паливом обираю кількість палива на поповнення, що і 
             * є резульататом, що суммується.
             */

            if (comboBox1.SelectedItem != null)
            {
                foreach (var a in query.Select(c => c.Вид_палива))
                {
                    var name =
                        context.Fs.Where(p => p.Назва_ПС == comboBox1.SelectedItem.ToString())
                            .FirstOrDefault(p => p.Вид_палива == a);
                    {
                        if (name == null) continue;

                        var addFuel = query.Single(c => c.Вид_палива == a).Поповнити_у_кількості;
                        if (addFuel != null)
                            name.Поточний_об_єм_палива += (float) addFuel;

                        my.Log($"Поповнення {name.Вид_палива} на {addFuel}л. у {name.Назва_ПС}");

                        // Відміняю зміни, якщо сумма перевищує максимальну кількість
                        if (name.Поточний_об_єм_палива > name.Макс__об_єм_палива)
                        {
                            name.Поточний_об_єм_палива -= (float) addFuel;

                            my.Log($"Помилка вводу, сума доданого палива({name.Вид_палива}) " +
                                   $"до залишку перевищує максимальний oб'єм");

                            MessageBox.Show(
                                Resources.Form5_ToMuch, @"Помилка вводу",MessageBoxButtons.OK, MessageBoxIcon.Error);

                            context.ExecuteCommand("DELETE FROM Restock");
                            restockTableAdapter.Fill(aZSCommandDataSet.Restock);
                        }
                    }
                }
                if (context.Restock.Any())
                {
                    context.FuelStations.Context.SubmitChanges();

                    MessageBox.Show(@"Паливо додане до залишку!", @"Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(@"Оберіть паливну станцію", @"Увага", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            _f1.fuelStationTableAdapter.Fill(_f1.aZSCommandDataSet.FuelStation);
        }

        /// <summary>
        /// Забирає повтори з таблиці FuelStation з стовпця Назва_ПС
        /// </summary>
        public string[] Distincter()
        {
            var context = new NutshellContext();
            var query = from c in context.FuelStations
                        select c.Назва_ПС;

            return query.Distinct().ToArray();
        }

        /// <summary>
        /// Заповнює ComboBox значеннями відфільтрованого запиту
        /// </summary>
        public void ComboBoxFiller()
        {
            foreach (var name in Distincter())
            {
               comboBox1.Items.Add(name);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            fuelTableAdapter.Update(aZSCommandDataSet);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var headerText =
               dataGridView2.Columns[e.ColumnIndex].HeaderText;

            if (headerText.Equals("Вид палива")) return;

            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dataGridView2.Rows[e.RowIndex].ErrorText =
                    $"{headerText} не може бути пустим";
                e.Cancel = true;
            }
        }
        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var headerText =
               dataGridView2.Columns[e.ColumnIndex].HeaderText;

            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dataGridView2.Rows[e.RowIndex].ErrorText =
                    $"{headerText} не може бути пустим";
                e.Cancel = true;
            }
        }


        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var header = dataGridView1.CurrentCell.OwningColumn.HeaderText;
            MessageBox.Show($"\"{header}\" не може містити літери",
                $"Стовпець:{e.ColumnIndex + 1}  Рядок:{e.RowIndex + 1}", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            var header = dataGridView2.CurrentCell.OwningColumn.HeaderText;
            MessageBox.Show($"\"{header}\" не може містити літери",
                $"Стовпець:{e.ColumnIndex + 1}  Рядок:{e.RowIndex}", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }
    }
}
