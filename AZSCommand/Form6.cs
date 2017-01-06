using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AZSCommand
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var logs = Environment.CurrentDirectory + @"\Logs";

            var dt = comboBox1.SelectedItem.ToString();

            Process.Start(logs + @"\Log[" + dt + @"].txt");
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            var my = new MyTools();

            foreach (var date in my.Date())
            {
                comboBox1.Items.Add(date.ToShortDateString());
            }
        }
    }
}
