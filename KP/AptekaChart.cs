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
        public class ChartData
        {
            public string manufact { get; set; }
            public double price { get; set; }
        }
        private void AptekaChart_Load(object sender, EventArgs e)
        {
            try
            {
                string path = "Apteka.txt";
                int N = 1;
                if (new FileInfo(path).Length == 0)
                {
                    throw new Exception("Файл пустой!");
                }
                List<ChartData> dat = new List<ChartData>();
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                using (StreamReader reader1 = new StreamReader(path))
                {
                    string str1;
                    while ((str1 = reader1.ReadLine()) != null)
                    {
                        if (str1.Contains('/'))
                        {
                            N++;
                        }
                    }
                    reader1.Close();
                }
                using (StreamReader reader2 = new StreamReader(path))
                {
                    string manuf, pr, line;
                    for (int i = 0; i < N; i++)
                    {
                        while ((line = reader2.ReadLine()) != null)
                        {
                            if (line.Contains("Производитель:"))
                            {
                                manuf = line;
                                manuf = manuf.Substring(manuf.IndexOf(':') + 1).Replace(" ", "");
                                dat.Add(new ChartData
                                {
                                    manufact = manuf
                                });
                            }
                            if (line.Contains("Цена со скидкой (руб.):"))
                            {
                                pr = line;
                                pr = pr.Substring(pr.IndexOf(':') + 1).Replace(" ", "");
                                dat.Add(new ChartData
                                {
                                    price = Convert.ToDouble(pr)
                                });
                            }
                            if (line.Contains('/'))
                            {
                                chart1.Series["Series1"].Points.AddXY(dat[0].manufact, dat[1].price);
                                dat.Clear();
                                break;
                            }
                        }
                    }
                    reader2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
