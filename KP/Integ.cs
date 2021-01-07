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
    public partial class Integ : Form
    {
        public void CreateChartInteg(int a, int b, double n, int o) //функция построения графика
        {
            double x, y;
            chartInteg.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Integral.FuncInteg(x);
                chartInteg.Series[0].Points.AddXY(x * o, y);
                x += n;
            }
        }
        public void InputCheckInteg1(object sender, KeyPressEventArgs e, int a) //функция, с помощью которой проверяется ввод с клавиатуры в textbox-ы
        {
            if (a == 0)                 //запрет на ввод нуля первым и других символов, кроме цифр.
                if (e.KeyChar == '0')   //ввод "-" один раз и только в начале
                    e.Handled = true;
            if (((TextBox)sender).Text.Contains('-'))
            {
                if (!((Char.IsDigit(e.KeyChar) && ((TextBox)sender).SelectionStart > 0) || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
            else if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == '-' && ((TextBox)sender).SelectionStart == 0)))
                e.Handled = true;
        }
        public void InputCneckInteg2(object sender, KeyPressEventArgs e, int a) //функция, с помощью которой проверяется ввод с клавиатуры в textbox-ы
        {
            if (a == 0)                                   //запрет на ввод нуля первым и других символов, кроме цифр
                if (e.KeyChar == '0') e.Handled = true;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
        public Integ()
        {
            InitializeComponent();
        }
        private void Integ_Load(object sender, EventArgs e) //событие загрузки формы
        {
            InputIntegLowLimit.MaxLength = 3; //установка размера строки некоторым textbox-ам
            InputIntegUpLimit.MaxLength = 3;
            InputIntegSegments.MaxLength = 7;
            InputIntegEps.MaxLength = 5;
            buttonIntegBackToMenu.FlatAppearance.BorderSize = 0;
            buttonIntegBackToMenu.FlatStyle = FlatStyle.Flat;
            CreateChartInteg(-99, 99, 1, 1); //вызов функции построения графика после загрузки формы
        }
        private void buttonIntegCalc_Click(object sender, EventArgs e) //событие нажатия кнопки "Рассчитать"
        {
            try
            {   //проверка на ввод в textbox-ы определённых значений
                if ((InputIntegLowLimit.Text == string.Empty) || (InputIntegUpLimit.Text == string.Empty) || (InputIntegSegments.Text == string.Empty) || (InputIntegEps.Text == string.Empty))
                {
                    throw new Exception("Введены не все данные для расчёта!");
                }
                if (Convert.ToInt32(InputIntegLowLimit.Text) > 99 || Convert.ToInt32(InputIntegLowLimit.Text) < -99)
                {
                    InputIntegLowLimit.Text = string.Empty;
                    throw new Exception("Нижний предел должен быть в интервале от -99 до 99!");
                }
                if (Convert.ToInt32(InputIntegUpLimit.Text) > 99 || Convert.ToInt32(InputIntegUpLimit.Text) < -99)
                {
                    InputIntegUpLimit.Text = string.Empty;
                    throw new Exception("Верхний предел должен быть в интервале от -99 до 99!");
                }
                if (Convert.ToInt32(InputIntegSegments.Text) > 1000000)
                {
                    InputIntegSegments.Text = string.Empty;
                    throw new Exception("Количество сегментов не может быть больше 1000000!");
                }
                if (Convert.ToDouble(InputIntegEps.Text) > 1 || Convert.ToDouble(InputIntegEps.Text) < 0.001)
                {
                    InputIntegEps.Text = string.Empty;
                    throw new Exception("Точность должна быть в интервале от 1 до 0,001!");
                }
                if (Convert.ToInt32(InputIntegLowLimit.Text) == Convert.ToInt32(InputIntegUpLimit.Text))
                {
                    InputIntegLowLimit.Text = string.Empty;
                    InputIntegUpLimit.Text = string.Empty;
                    throw new Exception("Пределы не могут быть равны!");
                }
                //вызов функции для расчёта интеграла
                Integral.CalcInteg(Convert.ToInt32(InputIntegLowLimit.Text), Convert.ToInt32(InputIntegUpLimit.Text), Convert.ToInt32(InputIntegSegments.Text), Convert.ToDouble(InputIntegEps.Text), out double res);
                OutputIntegCalc.Text = res.ToString(); //присваивание textbox-у с ответом результата
                //проверка некоторых значений, необходимых для построения графика
                if (Convert.ToInt32(InputIntegLowLimit.Text) < Convert.ToInt32(InputIntegUpLimit.Text))
                {
                    CreateChartInteg(Convert.ToInt32(InputIntegLowLimit.Text), Convert.ToInt32(InputIntegUpLimit.Text),1, 1); //вызов функции построения графика 
                }
                else
                {
                    CreateChartInteg(Convert.ToInt32(InputIntegUpLimit.Text), Convert.ToInt32(InputIntegLowLimit.Text), 1, -1); //вызов функции построения графика 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonIntegResetTextBox_Click(object sender, EventArgs e) //событие нажатия кнопки "Сбросить"
        {
            InputIntegLowLimit.Text = string.Empty; //обнуление всех textbox-ов 
            InputIntegUpLimit.Text = string.Empty;
            InputIntegSegments.Text = string.Empty;
            OutputIntegCalc.Text = string.Empty;
            InputIntegEps.Text = string.Empty;
            CreateChartInteg(-99, 99, 1, 1); //вызов функции для построения нового графика
        }
        private void InputIntegLowLimit_KeyPress(object sender, KeyPressEventArgs e) //событие нажатия клавиши в textbox-е
        {
            InputCheckInteg1(sender, e, InputIntegLowLimit.Text.Length); //вызов функции для проверки ввода определённых символов с клавиатуры
        }
        private void InputIntegUpLimit_KeyPress(object sender, KeyPressEventArgs e) //событие нажатия клавиши в textbox-е
        {
            InputCheckInteg1(sender, e, InputIntegUpLimit.Text.Length); //вызов функции для проверки ввода определённых символов с клавиатуры
        }
        private void buttonIntegBackToMenu_Click(object sender, EventArgs e) //событие нажатия кнопки "назад"
        {
            MainForm newForm = new MainForm(); //возврат в главное меню и закрытие предыдущей формы
            this.Close();
            newForm.Hide();
        }
        private void InputIntegSegments_KeyPress(object sender, KeyPressEventArgs e) //событие нажатия клавиши в textbox-е
        {
            InputCneckInteg2(sender, e, InputIntegSegments.Text.Length); //вызов функции для проверки ввода определённых символов с клавиатуры
        }
        private void InputIntegEps_KeyPress(object sender, KeyPressEventArgs e)  //событие нажатия клавиши в textbox-е
        {
            if ((e.KeyChar == ','))                 //Ввод в textbox только одно запятой, одни цифры
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
                return;
            }
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if ((e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                }
            }
        }
    }
}