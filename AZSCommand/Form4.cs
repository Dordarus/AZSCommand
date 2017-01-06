using System;
using System.Windows.Forms;

namespace AZSCommand
{
    public partial class Form4 : Form
    {
        public int Index { get; private set; }

        private readonly Form1 _f1;

        public Form4(Form1 f)
        {
            InitializeComponent();
            _f1 = f;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            fuelStationTableAdapter.Fill(aZSCommandDataSet.FuelStation);
            fuelTableAdapter.Fill(aZSCommandDataSet.Fuel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyTools my = new MyTools();

            fuelStationTableAdapter.Update(aZSCommandDataSet);

            my.Log("Додано нову ПС: " + ToLog());

            MessageBox.Show(@"Зміни збережено!", @"Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            _f1.fuelStationTableAdapter.Fill(_f1.aZSCommandDataSet.FuelStation);
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
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

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView2.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void dataGridView2_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            var header = dataGridView2.CurrentCell.OwningColumn.HeaderText;
            MessageBox.Show(e.Exception.Message,
                $"Стовпець:{e.ColumnIndex + 1}  Рядок:{e.RowIndex + 1}", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        private string ToLog()
        {
            MyTools my = new MyTools();

            var cells = dataGridView2.Rows[Index].Cells;
            var strings = string.Empty;

                for (int i = 0; i < cells.Count; i++)
                {
                    strings += $"{cells[i].OwningColumn.HeaderText} = {cells[i].Value} ";
                }

            return strings;
        }

        private void dataGridView2_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            Index = e.Row.Index - 1;
        }
    }
}
