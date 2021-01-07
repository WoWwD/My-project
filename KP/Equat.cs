using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace KP
{
    public partial class Equat : Form
    {
        public void CreateChartEquat(double a, double b, int n) //функция построения графика
        {

            double x, y;
            chartEquat.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Math.Log(x) - Math.Sqrt(4 - x); ;
                chartEquat.Series[0].Points.AddXY(x, y);
                x += n;
            }
        }
        public void InputCheckEquat1(KeyPressEventArgs e) //функция, с помощью которой проверяется ввод с клавиатуры в textbox-ы
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ','))) //ввод только цифр и только одной запятой
            {
                if (e.KeyChar != (char)Keys.Back)
                { e.Handled = true; }
            }
        }
        public Equat()
        {
            InitializeComponent();
        }
        private void Equat_Load(object sender, EventArgs e) //событие загрузки формы
        {
            InputEquatX0.MaxLength = 4;    //установка размера строки некоторым textbox-ам
            InputEquatEps.MaxLength = 15;
            buttonEquatBackToMenu.FlatAppearance.BorderSize = 0;
            buttonEquatBackToMenu.FlatStyle = FlatStyle.Flat;
            CreateChartEquat(1,5,1); //вызов функции построения графика
        }
        private void buttonEquatResetTextBox_Click(object sender, EventArgs e) //событие нажатия кнопки "Сбросить"
        {
            InputEquatEps.Text = string.Empty;   //обнуление всех textbox-ов
            OutputEquatN.Text = string.Empty;
            OutputEquatRes.Text = string.Empty;
            InputEquatX0.Text = string.Empty;
        }
        private void buttonEquatCalc_Click(object sender, EventArgs e) //событие нажатия кнопки "Рассчитать"
        {
            try
            {   //проверка на ввод в textbox-ы определённых значений
                if ((InputEquatX0.Text == string.Empty) || (InputEquatEps.Text == string.Empty))
                {
                    throw new Exception("Введены не все данные для расчёта!");
                }
                if (Convert.ToDouble(InputEquatEps.Text) == 0 || Convert.ToDouble(InputEquatEps.Text) > 1)
                {
                    InputEquatEps.Text = string.Empty;
                    throw new Exception("Точность не может быть больше 1 или равняться нулю");
                }
                if (Convert.ToDouble(InputEquatX0.Text) <= 0 || Convert.ToDouble(InputEquatX0.Text) > 4)
                {
                    InputEquatX0.Text = string.Empty;
                    throw new Exception("Корень должен входить в интервал от 0 до 4!");
                }
                Equation.CalcEquat(Convert.ToDouble(InputEquatX0.Text), Convert.ToDouble(InputEquatEps.Text), out double res, out int nres); //вызов функции расчёта уравнения
                OutputEquatRes.Text = res.ToString(); //присваивание textbox-ам результата переменных "Res" и "nRes"
                OutputEquatN.Text = nres.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEquatBackToMenu_Click(object sender, EventArgs e) //событие нажатия кнопки "назад"
        {
            MainForm newForm = new MainForm(); //возврат в главное меню и закрытие предыдущей формы
            this.Close();
            newForm.Hide();
        }
        private void InputEquatEps_KeyPress(object sender, KeyPressEventArgs e) //событие нажатия клавиши в textbox-е
        {
            InputCheckEquat1(e); //вызов функции для проверки ввода определённых символов с клавиатуры
        }
        private void InputEquatX0_KeyPress(object sender, KeyPressEventArgs e) //событие нажатия клавиши в textbox-е
        {
            InputCheckEquat1(e); //вызов функции для проверки ввода определённых символов с клавиатуры
        }
    }
}