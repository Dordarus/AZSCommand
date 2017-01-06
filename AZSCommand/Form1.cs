using System;
using System.Linq;
using System.Windows.Forms;

namespace AZSCommand
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Text = @"Оберіть ПС";

            var max = new ToolStripMenuItem("Найбільша кількість палива");
            var min = new ToolStripMenuItem("Найменша кількість палива");
            var all = new ToolStripMenuItem("Відобразити таблицю повністю");

            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { max, min, all });

            max.Click += max_Click;
            min.Click += min_Click;
            all.Click += all_Click;

            dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void max_Click(object sender, EventArgs e)
        {
            var context = new NutshellContext();

            fuelStationBindingSource.RemoveFilter();
            fuelStationBindingSource.Filter = 
                $"[Поточний об'єм палива] = '{context.FuelStations.Max(p=>p.Поточний_об_єм_палива)}'";

            comboBox1.Text = @"Оберіть ПС";

        }

        private void min_Click(object sender, EventArgs e)
        {
            var context = new NutshellContext();

            fuelStationBindingSource.RemoveFilter();
            fuelStationBindingSource.Filter = 
                $"[Поточний об'єм палива] = '{context.FuelStations.Min(p=>p.Поточний_об_єм_палива)}'";

            comboBox1.Text = @"Оберіть ПС";

        }

        private void all_Click(object sender, EventArgs e)
        {
            fuelStationBindingSource.RemoveFilter();
            fuelStationTableAdapter.Fill(aZSCommandDataSet.FuelStation);
            comboBox1.Text = @"Оберіть ПС";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(this);
            f2.ShowDialog() ;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4 f4 = new Form4(this);
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5(this);
            f5.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7(this);
            f7.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fuelStationTableAdapter.Fill(aZSCommandDataSet.FuelStation);
            carsTableAdapter.FillBy(aZSCommandDataSet.Cars);

            var my = new MyTools();
            foreach (var name in my.FillerName())
            {
                comboBox1.Items.Add(name);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fuelStationBindingSource.RemoveFilter();
            fuelStationBindingSource.Filter = $"[Назва ПС] = '{comboBox1.SelectedItem}'";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Form6 f6 = new Form6();
            f6.ShowDialog();

        }
    }
}
