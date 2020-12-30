
namespace KP
{
    partial class Apteka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EditDataGroupBox = new System.Windows.Forms.GroupBox();
            this.DeleteSelectionData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.AddAptekaData = new System.Windows.Forms.Button();
            this.InputDataGroupBox = new System.Windows.Forms.GroupBox();
            this.InputDiscount = new System.Windows.Forms.TextBox();
            this.InputPrice = new System.Windows.Forms.TextBox();
            this.InputManufact = new System.Windows.Forms.TextBox();
            this.InputName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EditDataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.InputDataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditDataGroupBox
            // 
            this.EditDataGroupBox.Controls.Add(this.DeleteSelectionData);
            this.EditDataGroupBox.Location = new System.Drawing.Point(577, 290);
            this.EditDataGroupBox.Name = "EditDataGroupBox";
            this.EditDataGroupBox.Size = new System.Drawing.Size(218, 186);
            this.EditDataGroupBox.TabIndex = 2;
            this.EditDataGroupBox.TabStop = false;
            this.EditDataGroupBox.Text = "Редактирование данных";
            // 
            // DeleteSelectionData
            // 
            this.DeleteSelectionData.Location = new System.Drawing.Point(18, 78);
            this.DeleteSelectionData.Name = "DeleteSelectionData";
            this.DeleteSelectionData.Size = new System.Drawing.Size(182, 35);
            this.DeleteSelectionData.TabIndex = 1;
            this.DeleteSelectionData.Text = "Удалить выделенное";
            this.DeleteSelectionData.UseVisualStyleBackColor = true;
            this.DeleteSelectionData.Click += new System.EventHandler(this.DeleteSelectionData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(779, 253);
            this.dataGridView1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(864, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AddAptekaData
            // 
            this.AddAptekaData.Location = new System.Drawing.Point(253, 109);
            this.AddAptekaData.Name = "AddAptekaData";
            this.AddAptekaData.Size = new System.Drawing.Size(110, 52);
            this.AddAptekaData.TabIndex = 6;
            this.AddAptekaData.Text = "Добавить";
            this.AddAptekaData.UseVisualStyleBackColor = true;
            this.AddAptekaData.Click += new System.EventHandler(this.AddData_Click);
            // 
            // InputDataGroupBox
            // 
            this.InputDataGroupBox.Controls.Add(this.AddAptekaData);
            this.InputDataGroupBox.Controls.Add(this.InputDiscount);
            this.InputDataGroupBox.Controls.Add(this.InputPrice);
            this.InputDataGroupBox.Controls.Add(this.InputManufact);
            this.InputDataGroupBox.Controls.Add(this.InputName);
            this.InputDataGroupBox.Controls.Add(this.label4);
            this.InputDataGroupBox.Controls.Add(this.label3);
            this.InputDataGroupBox.Controls.Add(this.label2);
            this.InputDataGroupBox.Controls.Add(this.label1);
            this.InputDataGroupBox.Location = new System.Drawing.Point(42, 290);
            this.InputDataGroupBox.Name = "InputDataGroupBox";
            this.InputDataGroupBox.Size = new System.Drawing.Size(404, 186);
            this.InputDataGroupBox.TabIndex = 1;
            this.InputDataGroupBox.TabStop = false;
            this.InputDataGroupBox.Text = "Ввод данных";
            // 
            // InputDiscount
            // 
            this.InputDiscount.Location = new System.Drawing.Point(110, 115);
            this.InputDiscount.Name = "InputDiscount";
            this.InputDiscount.Size = new System.Drawing.Size(100, 22);
            this.InputDiscount.TabIndex = 7;
            // 
            // InputPrice
            // 
            this.InputPrice.Location = new System.Drawing.Point(113, 84);
            this.InputPrice.Name = "InputPrice";
            this.InputPrice.Size = new System.Drawing.Size(100, 22);
            this.InputPrice.TabIndex = 6;
            // 
            // InputManufact
            // 
            this.InputManufact.Location = new System.Drawing.Point(127, 51);
            this.InputManufact.Name = "InputManufact";
            this.InputManufact.Size = new System.Drawing.Size(100, 22);
            this.InputManufact.TabIndex = 5;
            // 
            // InputName
            // 
            this.InputName.Location = new System.Drawing.Point(176, 23);
            this.InputName.Name = "InputName";
            this.InputName.Size = new System.Drawing.Size(100, 22);
            this.InputName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Скидка (%):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена (руб.):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Изготовитель:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название препарата:";
            // 
            // Apteka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(864, 502);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EditDataGroupBox);
            this.Controls.Add(this.InputDataGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Apteka";
            this.Text = "Программа №1";
            this.Load += new System.EventHandler(this.Apteka_Load);
            this.EditDataGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.InputDataGroupBox.ResumeLayout(false);
            this.InputDataGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox EditDataGroupBox;
        private System.Windows.Forms.Button DeleteSelectionData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button AddAptekaData;
        private System.Windows.Forms.GroupBox InputDataGroupBox;
        private System.Windows.Forms.TextBox InputDiscount;
        private System.Windows.Forms.TextBox InputPrice;
        private System.Windows.Forms.TextBox InputManufact;
        private System.Windows.Forms.TextBox InputName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}