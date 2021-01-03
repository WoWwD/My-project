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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                AptekaChart frm2 = new AptekaChart();
                frm2.Show();
                //System.Diagnostics.Process.Start(Application.StartupPath + @"\.exe");
            }
            if (e.KeyCode == Keys.D2)
            {
                Integ frm2 = new Integ();
                frm2.Show();
            }
            if (e.KeyCode == Keys.D3)
            {
                Equat frm2 = new Equat();
                frm2.Show();
            }
        }
    }
}
