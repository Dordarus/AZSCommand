using System;
using System.Linq;
using System.Windows.Forms;

namespace AZSCommand
{
    public partial class Form3 : Form
    {
        private readonly Form2 _f2;

        public Form3(Form2 f)
        {
            InitializeComponent();
            _f2 = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var context = new NutshellContext();
            var my = new MyTools();
            var tb5 = Convert.ToSingle(textBox5.Text.Replace(".", ","));

            try
            {
                var newModel = new Models
                {
                    ID = context.Model.Count() + 1,
                    Модель = textBox4.Text,
                    Об_єм_баку = tb5,
                    Тип_палива = comboBox1.SelectedText
                };
                context.Models.InsertOnSubmit(newModel);
                context.Models.Context.SubmitChanges();

                my.Log($"Додано модель Модель: {textBox4.Text} Об'єм баку: {tb5} Тип палива: {comboBox1.SelectedText}");

                MessageBox.Show(@"Модель успішно додана у БД");
                Close();
            }
            catch (FormatException)
            {
                if (textBox5.Text == string.Empty)
                {
                    MessageBox.Show(@"Поле ""Об'єм баку"" не може бути пустим");
                }
                else
                {
                    MessageBox.Show(@"Поле ""Об'єм баку"" не може містити літери");
                    textBox5.Text = string.Empty;
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox4.Text = _f2.TextSender();
            Filler();
        }

        public void Filler()
        {
            var context = new NutshellContext();

            var query = context.Fuel
                .Select(p => p.Тип_палива).Distinct();

            foreach (var name in query)
            {
                comboBox1.Items.Add(name);
            }
        }
    }
}
