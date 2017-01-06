using System;
using System.Linq;
using System.Windows.Forms;

namespace AZSCommand
{
    public partial class Form7 : Form
    {
        private readonly Form1 _f1;

        public Form7(Form1 f)
        {
            InitializeComponent();
            _f1 = f;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Filler();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var context = new NutshellContext();

            var prise = context.Fuel
                .Where(p => p.Вид_палива == comboBox1.SelectedItem.ToString())
                .Select(p => p.Ціна).FirstOrDefault();
            textBox1.Text = string.Format("{0:N2}", prise);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                if (textBox2.Text == string.Empty)
                    textBox3.Text = @"Ціна";
                else
                {
                    try
                    {
                        var sum =
                            Convert.ToString(Convert.ToDecimal(textBox1.Text)*
                                             Convert.ToDecimal(textBox2.Text.Replace(".", ",")));
                        textBox3.Text = string.Format("{0:N2}", sum);
                    }
                    catch (FormatException)
                    {
                        textBox3.Clear();
                        MessageBox.Show(@"Поле ""Об'єм"" не може містити літери", @"Помилка",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Оберіть Вид палива", @"Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTools my = new MyTools();

            var context = new NutshellContext();

            if (comboBox2.SelectedItem != null)
            {
                var query = context.Fs.Where(p => p.Назва_ПС == comboBox2.SelectedItem.ToString())
                    .FirstOrDefault(p => p.Вид_палива == comboBox1.SelectedItem.ToString());

                if (query != null)
                {
                    if (Convert.ToSingle(textBox2.Text) <= query.Поточний_об_єм_палива)
                    {
                        query.Поточний_об_єм_палива -= Convert.ToSingle(textBox2.Text);

                        my.Log($"Клієнта розраховано Кількість {query.Вид_палива} " +
                               $"зменшилась на {Convert.ToSingle(textBox2.Text)}л. y {query.Назва_ПС}");
                    }
                    else if (query.Поточний_об_єм_палива <= 100.0)
                    {
                        my.Log($"Критично мала кількість {query.Поточний_об_єм_палива}л. палива {query.Вид_палива} у {query.Назва_ПС}");

                        MessageBox.Show(
                            $"Лишилось надто мало палива {comboBox1.SelectedItem} " +
                            $"на паливній станції {comboBox2.SelectedItem}\nНеобхідно поповнити паливо!",
                            @"Увага!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        query.Поточний_об_єм_палива += Convert.ToSingle(textBox2.Text);

                        my.Log($"Невдала спроба розрахувати клієнта! {query.Вид_палива} " +
                               $"надто мало({query.Поточний_об_єм_палива}л.) для заправки");

                        MessageBox.Show(
                            $"{comboBox1.SelectedItem} - палива не достатньо для заправки автомобіля!\nЗапропонуйте інакше паливо!",
                            @"Увага!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    context.FuelStations.Context.SubmitChanges();
                }

                MessageBox.Show(@"Клієнта розраховано!", @"Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"Оберіть Паливну станцію", @"Увага!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Filler()
        {
            var context = new NutshellContext();

            var query = context.Fuel
                .Select(p => p.Вид_палива).ToArray();

            foreach (var name in query)
            {
                comboBox1.Items.Add(name);
            }

            foreach (var name in Distincter())
            {
                comboBox2.Items.Add(name);
            }
        }

        public string[] Distincter()
        {
            var context = new NutshellContext();
            var query = from c in context.FuelStations
                        select c.Назва_ПС;

            return query.Distinct().ToArray();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            _f1.fuelStationTableAdapter.Fill(_f1.aZSCommandDataSet.FuelStation);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = string.Empty;
        }
    }
}