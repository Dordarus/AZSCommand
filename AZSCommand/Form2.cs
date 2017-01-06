using System;
using System.Linq;
using System.Windows.Forms;

namespace AZSCommand
{
    public partial class Form2 : Form
    {
        private readonly Form3 _f3;
        private readonly Form1 _f1;

        public Form2(Form1 f)
        {
            InitializeComponent();
            _f3 = new Form3(this);
            _f1 = f;
        }

        public string TextSender() => textBox2.Text;

        private void button1_Click(object sender, EventArgs e)
        {
            var my = new MyTools();

            var context = new NutshellContext();

            var counter = 1;

            for (var i = 1; i <= context.Model.Count(); i++)
            {
                var t = context.Model.Single(c => c.ID == i);

                if (textBox2.Text.ToLower().Replace(" ", "") == t.Модель.ToLower().Replace(" ", ""))
                {
                    var newCar = new Cars
                    {
                        ID = context.Car.Count() + 1,
                        Марка_автомобіля = textBox1.Text,
                        Модель = textBox2.Text,
                        Номерний_знак = textBox3.Text.ToUpper()
                    };
                    context.Cars.InsertOnSubmit(newCar);
                    context.Cars.Context.SubmitChanges();

                    my.Log($"Додано автомобіль Марка: {textBox1.Text} Модель: {textBox2.Text} Номерний знак: {textBox3.Text}");

                    MessageBox.Show(@"Автомобіль успішно додано!");
                    Close();
                }
                else
                {
                    counter++;
                    if (counter == context.Model.Count()+1)
                    {
                        if (MessageBox.Show("Даної Моделі Автомобіля у БД немає!\nНеобхідно оновити БД Моделі",
                            @"Увага!",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation) == DialogResult.OK)
                        {
                            _f3.ShowDialog();

                            counter = 1;
                            i = 1;
                        }
                    }
                }
            }
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            _f1.carsTableAdapter.FillBy(_f1.aZSCommandDataSet.Cars);
        }
    }
}
