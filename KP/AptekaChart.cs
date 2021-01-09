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
            public string name { get; set; } //название препарата
            public double price { get; set; } //цена препарата
        }
        private void AptekaChart_Load(object sender, EventArgs e)
        {
            string path = @"..\..\..\apteka.txt"; //путь к файлу с данными
            int N = 1;
            if (new FileInfo(path).Length == 0) //проверка на пустоту файла
            {
                throw new Exception("Файл пустой!");
            }
            List<ChartData> dat = new List<ChartData>(); //создание списка полей для построения диаграммы
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;  //удаление осей Y на диаграмме
            chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
            using (StreamReader reader1 = new StreamReader(path))
            {
                string str1;
                while ((str1 = reader1.ReadLine()) != null) //подсчёт количества структур 
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
                    while ((line = reader2.ReadLine()) != null) //запись значений из файла в поля для построения диаграммы
                    {
                        if (line.Contains("Название препарата:"))
                        {
                            manuf = line;
                            manuf = manuf.Substring(manuf.IndexOf(':') + 1).Replace(" ", "");
                            dat.Add(new ChartData
                            {
                                name = manuf
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
                            chart1.Series["Series1"].Points.AddXY(dat[0].name, dat[1].price); //построение области на диаграмме
                            dat.Clear();
                            break;
                        }
                    }
                }
                reader2.Close();
            }
            
        }
    }
}
