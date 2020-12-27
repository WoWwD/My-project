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
        public void CreateChartEquat(double a, double b, int n)
        {
            double x, y;
            chartEquat.Series[0].Points.Clear();
            x = a;
            while (x <= b)
            {
                y = Equation.FuncEquat(x);
                chartEquat.Series[0].Points.AddXY(x, y);
                x += n;
            }
        }
        public void InputCheckEquat1(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == ',')))
            {
                if (e.KeyChar != (char)Keys.Back)
                { e.Handled = true; }
            }
        }
        public Equat()
        {
            InitializeComponent();
        }
        private void Equat_Load(object sender, EventArgs e)
        {
            InputEquatChartA.MaxLength = 2;
            InputEquatChartB.MaxLength = 2;
            InputEquatChartN.MaxLength = 2;
            InputEquatX0.MaxLength = 6;
            InputEquatEps.MaxLength = 18;
            InputEquatEps.Text = "0,00001";
            InputEquatChartA.Text = "1";
            InputEquatChartB.Text = "10";
            InputEquatChartN.Text = "1";
            buttonEquatBackToMenu.FlatAppearance.BorderSize = 0;
            buttonEquatBackToMenu.FlatStyle = FlatStyle.Flat;
            CreateChartEquat(1,10,1);
        }
        private void buttonEquatResetTextBox_Click(object sender, EventArgs e)
        {
            InputEquatEps.Text = string.Empty;
            InputEquatX0.Text = string.Empty;
            OutputEquatN.Text = string.Empty;
            OutputEquatRes.Text = string.Empty;
        }
        private void buttonEquatCalc_Click(object sender, EventArgs e)
        {
            try
            {
                if ((InputEquatX0.Text == string.Empty) || (InputEquatEps.Text == string.Empty))
                {
                    throw new Exception("Введены не все данные для расчёта!");
                }
                if (Convert.ToDouble(InputEquatEps.Text) == 0)
                {
                    InputEquatEps.Text = string.Empty;
                    throw new Exception("Точность не может быть равна нулю!");
                }
                if (Convert.ToDouble(InputEquatX0.Text) > 99)
                {
                    InputEquatEps.Text = string.Empty;
                    throw new Exception("Корень не может быть больше 99!");
                }
                if (Convert.ToDouble(InputEquatX0.Text) < 0)
                {
                    InputEquatX0.Text = string.Empty;
                    throw new Exception("Корень не может быть отрицательным!");
                }
                if (Convert.ToDouble(InputEquatX0.Text) == 0)
                {
                    InputEquatX0.Text = string.Empty;
                    throw new Exception("Корень не может быть равен нулю!");
                }
                Equation.CalcEquat(Convert.ToDouble(InputEquatX0.Text), Convert.ToDouble(InputEquatEps.Text), out double res, out double nres);
                OutputEquatRes.Text = res.ToString();
                OutputEquatN.Text = nres.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEquatBackToMenu_Click(object sender, EventArgs e)
        {
            MainForm newForm = new MainForm();
            this.Close();
            newForm.Hide();
        }
        private void buttonEquatCreateChart_Click(object sender, EventArgs e)
        {
            try
            {
                if ((InputEquatChartA.Text == string.Empty) || (InputEquatChartB.Text == string.Empty) || (InputEquatChartN.Text == string.Empty))
                {
                    throw new Exception("Данные, нужные для построения графика, не введены!");
                }
                if (Convert.ToInt32(InputEquatChartA.Text) > Convert.ToInt32(InputEquatChartB.Text))
                {
                    InputEquatChartB.Text = string.Empty;
                    throw new Exception("Правый интервал не может быть меньше левого!");
                }
                if (Convert.ToInt32(InputEquatChartB.Text) == Convert.ToInt32(InputEquatChartA.Text))
                {
                    InputEquatChartA.Text = string.Empty;
                    InputEquatChartB.Text = string.Empty;
                    throw new Exception("Интервалы не могут быть равны!");
                }
                if (Convert.ToInt32(InputEquatChartB.Text) - Convert.ToInt32(InputEquatChartA.Text) <
                    Convert.ToDouble(InputEquatChartN.Text))
                {
                    InputEquatChartN.Text = string.Empty;
                    throw new Exception("Количество делений не может быть равно такому значению!");
                }
                if (Convert.ToDouble(InputEquatChartN.Text) == 0)
                {
                    InputEquatChartN.Text = string.Empty;
                    throw new Exception("Количество делений не может быть равно нулю!");
                }
                CreateChartEquat(Convert.ToInt32(InputEquatChartA.Text), Convert.ToInt32(InputEquatChartB.Text), Convert.ToInt32(InputEquatChartN.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void InputEquatX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheckEquat1(e);
        }
        private void InputEquatEps_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputCheckEquat1(e);
        }
    }
}