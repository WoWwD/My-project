using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e) //функция, с помощью которой проверяется ввод с клавиатуры 
        {
            if (e.KeyCode == Keys.D1) //если нажата клавиша "1", то запустится консоль
            {
                System.Diagnostics.Process.Start(Application.StartupPath + @"..\..\..\..\Apteka\bin\Debug\Apteka.exe");
            }
            if (e.KeyCode == Keys.D2) //если нажата клавиша "2", то запустится форма с интегралом
            {
                Integ frm2 = new Integ();
                frm2.Show();
            }
            if (e.KeyCode == Keys.D3) //если нажата клавиша "3", то запустится форма с уравнением
            {
                Equat frm2 = new Equat();
                frm2.Show();
            }
        }
    }
}
