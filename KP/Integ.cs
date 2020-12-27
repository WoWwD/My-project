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
        public void CreateChartInteg(int a, int b, int n)
        {
            double x, y;
            chartInteg.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Integral.FuncInteg(x);
                chartInteg.Series[0].Points.AddXY(x, y);
                x += n;
            }
        }
        public void InputCheckInteg1(object sender, KeyPressEventArgs e, int a)
        {
            if (a == 0)
                if (e.KeyChar == '0')
                    e.Handled = true;
            if (((TextBox)sender).Text.Contains('-'))
            {
                if (!((Char.IsDigit(e.KeyChar) && ((TextBox)sender).SelectionStart > 0) || e.KeyChar == (char)Keys.Back))
                    e.Handled = true;
            }
            else if (!(Char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || (e.KeyChar == '-' && ((TextBox)sender).SelectionStart == 0)))
                e.Handled = true;
        }
        public void InputCneckInteg2(object sender, KeyPressEventArgs e, int a)
        {
            if (a == 0)
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
        private void Integ_Load(object sender, EventArgs e)
        {
            InputIntegChartA.MaxLength = 2;
            InputIntegChartB.MaxLength = 2;
            InputIntegChartN.MaxLength = 2;
            InputIntegLowLimit.MaxLength = 3;
            InputIntegUpLimit.MaxLength = 3;
            InputIntegSegments.MaxLength = 7;
            InputIntegChartA.Text = "1";
            InputIntegChartB.Text = "99";
            InputIntegChartN.Text = "1";
            buttonIntegBackToMenu.FlatAppearance.BorderSize = 0;
            buttonIntegBackToMenu.FlatStyle = FlatStyle.Flat;
            CreateChartInteg(1, 99, 1);
        }
        private void buttonIntegCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if ((InputIntegLowLimit.Text == string.Empty) || (InputIntegUpLimit.Text == string.Empty) || (InputIntegSegments.Text == string.Empty))
                {
                    throw new Exception("Введены не все данные для расчёта!");
                }
                if (Convert.ToInt32(InputIntegLowLimit.Text) > 99 || Convert.ToInt32(InputIntegLowLimit.Text) < -99)
                {
                    InputIntegLowLimit.Text = string.Empty;
                    throw new Exception("Нижний предел должен быть в диапазоне от -99 до 99!");
                }
                if (Convert.ToInt32(InputIntegUpLimit.Text) > 99 || Convert.ToInt32(InputIntegUpLimit.Text) < -99)
                {
                    InputIntegUpLimit.Text = string.Empty;
                    throw new Exception("Верхний предел должен быть в диапазоне от -99 до 99!");
                }
                if (Convert.ToInt32(InputIntegSegments.Text) > 1000000)
                {
                    InputIntegSegments.Text = string.Empty;
                    throw new Exception("Количество сегментов не может быть больше 1000000!");
                }
                Integral.CalcInteg(Convert.ToDouble(InputIntegLowLimit.Text), Convert.ToDouble(InputIntegUpLimit.Text), Convert.ToInt32(InputIntegSegments.Text), out double res);
                OutputIntegCalc.Text = res.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonIntegCreateChart_Click(object sender, EventArgs e)
        {
            try
            {
                if ((InputIntegChartA.Text == string.Empty) || (InputIntegChartB.Text == string.Empty) || (InputIntegChartN.Text == string.Empty))
                {
                    throw new Exception("Данные, нужные для построения графика, не введены!");
                }
                if (Convert.ToInt32(InputIntegChartA.Text) > Convert.ToInt32(InputIntegChartB.Text))
                {
                    InputIntegChartB.Text = string.Empty;
                    throw new Exception("Правый интервал не может быть меньше левого!");
                }
                if (Convert.ToInt32(InputIntegChartB.Text) == Convert.ToInt32(InputIntegChartA.Text))
                {
                    InputIntegChartA.Text = string.Empty;
                    InputIntegChartB.Text = string.Empty;
                    throw new Exception("Интервалы не могут быть равны!");
                }
                if (Convert.ToInt32(InputIntegChartB.Text) - Convert.ToInt32(InputIntegChartA.Text) <
                    Convert.ToDouble(InputIntegChartN.Text))
                {
                    InputIntegChartN.Text = string.Empty;
                    throw new Exception("Количество делений не может быть равно такому значению!");
                }
                if (Convert.ToDouble(InputIntegChartN.Text) == 0)
                {
                    InputIntegChartN.Text = string.Empty;
                    throw new Exception("Количество делений не может быть равно нулю!");
                }
                CreateChartInteg(Convert.ToInt32(InputIntegChartA.Text), Convert.ToInt32(InputIntegChartB.Text), Convert.ToInt32(InputIntegChartN.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonIntegResetTextBox_Click(object sender, EventArgs e)
        {
            InputIntegLowLimit.Text = string.Empty;
            InputIntegUpLimit.Text = string.Empty;
            InputIntegSegments.Text = string.Empty;
            OutputIntegCalc.Text = string.Empty;
        }
        private void InputIntegLowLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheckInteg1(sender, e, InputIntegLowLimit.Text.Length);
        }
        private void InputIntegUpLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheckInteg1(sender, e, InputIntegUpLimit.Text.Length);
        }
        private void InputIntegChartA_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCneckInteg2(sender, e, InputIntegChartA.Text.Length);
        }
        private void InputIntegChartB_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCneckInteg2(sender, e, InputIntegChartB.Text.Length);
        }
        private void InputIntegChartN_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCneckInteg2(sender, e, InputIntegChartN.Text.Length);
        }
        private void buttonIntegBackToMenu_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            this.Close();
            newForm.Hide();
        }
    }
}