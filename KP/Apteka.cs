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
    public partial class Apteka : Form
    {
        DataTable table = new DataTable();
        public Apteka()
        {
            InitializeComponent();
        }
        private BindingList<AptekaData> dataApt = new BindingList<AptekaData>();
        private void Add()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataApt;
        }
        private void AddData_Click(object sender, EventArgs e)
        {

            try
            {
                dataApt.Add(new AptekaData
                {
                    name = textBoxInputName.Text,
                    manufact = textBoxInputManufact.Text,
                    price = Convert.ToDouble(textBoxInputPrice.Text),
                    discount = Convert.ToDouble(textBoxInputDiscount.Text),
                    discountedPrice = Convert.ToDouble(textBoxInputPrice.Text) - ((Convert.ToDouble(textBoxInputPrice.Text) * Convert.ToDouble(textBoxInputDiscount.Text) / 100))
                });
                Add();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stReam = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stReam = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader read = new StreamReader(stReam);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = read.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridView1.RowCount = num;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split('^');
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                try
                                {
                                    dataGridView1.Rows[i].Cells[j].Value = str[j];
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        read.Close();
                    }
                }
                stReam.Close();
            }
        }
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream stream;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog1.OpenFile()) != null)
                {
                    StreamWriter wri = new StreamWriter(stream);
                    try
                    {
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                wri.Write(dataGridView1.Rows[i].Cells[j].Value.ToString() + '^');
                            }
                            wri.WriteLine();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        wri.Close();
                    }
                    stream.Close();
                }
            }
        }
        private void DeleteSelectionData_Click(object sender, EventArgs e)
        {
            dataApt.RemoveAt(dataGridView1.SelectedRows[0].Index);
            Add();
        }

        private void Apteka_Load(object sender, EventArgs e)
        {
            //table.Columns.Add("Название",typeof(string));
            //table.Columns.Add("Производитель", typeof(string));
            //table.Columns.Add("Цена (руб.)", typeof(double));
            //table.Columns.Add("Скидка (%)", typeof(double));
            //table.Columns.Add("Цена со скидкой (руб.)", typeof(double));
            //dataGridView1.DataSource = table;
        }
    }
}
