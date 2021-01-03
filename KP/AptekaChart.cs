using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP
{
    public partial class AptekaChart : Form
    {
        public AptekaChart()
        {
            InitializeComponent();
        }

        private void AptekaChart_Load(object sender, EventArgs e)
        {
            string[] text1 = File.ReadAllLines("D:\\Apteka.txt");
            for (int i = 0; i < text1.Length; i++)
            {
                if (text1[i].Contains("Название препарата:"))
                    textBox1.Text += text1[i] + Environment.NewLine;
            }
            string[] text2 = File.ReadAllLines("D:\\Apteka.txt");
            for (int i = 0; i < text2.Length; i++)
            {
                if (text2[i].Contains("Цена со скидкой (руб.):"))
                    textBox2.Text += text2[i] + Environment.NewLine;
            }
        }
    }
}
