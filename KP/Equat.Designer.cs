
namespace KP
{
    partial class Equat
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equat));
            this.InputEquatX0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OutputEquatN = new System.Windows.Forms.TextBox();
            this.OutputEquatRes = new System.Windows.Forms.TextBox();
            this.InputEquatEps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxInputEquatDataForCalc = new System.Windows.Forms.GroupBox();
            this.buttonEquatResetTextBox = new System.Windows.Forms.Button();
            this.buttonEquatCalc = new System.Windows.Forms.Button();
            this.chartEquat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonEquatBackToMenu = new System.Windows.Forms.Button();
            this.groupBoxInputEquatDataForCreateChart = new System.Windows.Forms.GroupBox();
            this.InputEquatChartN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEquatCreateChart = new System.Windows.Forms.Button();
            this.InputEquatChartB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.InputEquatChartA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxInputEquatDataForCalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEquat)).BeginInit();
            this.groupBoxInputEquatDataForCreateChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputEquatX0
            // 
            this.InputEquatX0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatX0.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatX0.Location = new System.Drawing.Point(133, 36);
            this.InputEquatX0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputEquatX0.Name = "InputEquatX0";
            this.InputEquatX0.Size = new System.Drawing.Size(94, 23);
            this.InputEquatX0.TabIndex = 1;
            this.InputEquatX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputEquatX0_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Значение корня =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ответ = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 120);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество итераций = ";
            // 
            // OutputEquatN
            // 
            this.OutputEquatN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputEquatN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputEquatN.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputEquatN.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputEquatN.Location = new System.Drawing.Point(189, 118);
            this.OutputEquatN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputEquatN.Name = "OutputEquatN";
            this.OutputEquatN.ReadOnly = true;
            this.OutputEquatN.Size = new System.Drawing.Size(38, 23);
            this.OutputEquatN.TabIndex = 15;
            this.OutputEquatN.TabStop = false;
            // 
            // OutputEquatRes
            // 
            this.OutputEquatRes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputEquatRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputEquatRes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputEquatRes.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputEquatRes.Location = new System.Drawing.Point(73, 158);
            this.OutputEquatRes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OutputEquatRes.Name = "OutputEquatRes";
            this.OutputEquatRes.ReadOnly = true;
            this.OutputEquatRes.Size = new System.Drawing.Size(154, 23);
            this.OutputEquatRes.TabIndex = 66;
            this.OutputEquatRes.TabStop = false;
            // 
            // InputEquatEps
            // 
            this.InputEquatEps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatEps.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatEps.Location = new System.Drawing.Point(92, 78);
            this.InputEquatEps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputEquatEps.Name = "InputEquatEps";
            this.InputEquatEps.Size = new System.Drawing.Size(135, 23);
            this.InputEquatEps.TabIndex = 2;
            this.InputEquatEps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputEquatEps_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 80);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Точность = ";
            // 
            // groupBoxInputEquatDataForCalc
            // 
            this.groupBoxInputEquatDataForCalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.buttonEquatResetTextBox);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.buttonEquatCalc);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.OutputEquatRes);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.InputEquatEps);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.OutputEquatN);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.label6);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.label3);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.label5);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.InputEquatX0);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.label4);
            this.groupBoxInputEquatDataForCalc.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputEquatDataForCalc.Location = new System.Drawing.Point(11, 309);
            this.groupBoxInputEquatDataForCalc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInputEquatDataForCalc.Name = "groupBoxInputEquatDataForCalc";
            this.groupBoxInputEquatDataForCalc.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInputEquatDataForCalc.Size = new System.Drawing.Size(388, 211);
            this.groupBoxInputEquatDataForCalc.TabIndex = 1;
            this.groupBoxInputEquatDataForCalc.TabStop = false;
            this.groupBoxInputEquatDataForCalc.Text = "Ввод значений";
            // 
            // buttonEquatResetTextBox
            // 
            this.buttonEquatResetTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEquatResetTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquatResetTextBox.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEquatResetTextBox.FlatAppearance.BorderSize = 4;
            this.buttonEquatResetTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEquatResetTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonEquatResetTextBox.ForeColor = System.Drawing.Color.White;
            this.buttonEquatResetTextBox.Location = new System.Drawing.Point(257, 136);
            this.buttonEquatResetTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEquatResetTextBox.Name = "buttonEquatResetTextBox";
            this.buttonEquatResetTextBox.Size = new System.Drawing.Size(100, 45);
            this.buttonEquatResetTextBox.TabIndex = 4;
            this.buttonEquatResetTextBox.Text = "Сбросить";
            this.buttonEquatResetTextBox.UseVisualStyleBackColor = false;
            this.buttonEquatResetTextBox.Click += new System.EventHandler(this.buttonEquatResetTextBox_Click);
            // 
            // buttonEquatCalc
            // 
            this.buttonEquatCalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEquatCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquatCalc.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEquatCalc.FlatAppearance.BorderSize = 4;
            this.buttonEquatCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEquatCalc.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonEquatCalc.ForeColor = System.Drawing.Color.White;
            this.buttonEquatCalc.Location = new System.Drawing.Point(257, 38);
            this.buttonEquatCalc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEquatCalc.Name = "buttonEquatCalc";
            this.buttonEquatCalc.Size = new System.Drawing.Size(100, 45);
            this.buttonEquatCalc.TabIndex = 3;
            this.buttonEquatCalc.Text = "Рассчитать";
            this.buttonEquatCalc.UseVisualStyleBackColor = false;
            this.buttonEquatCalc.Click += new System.EventHandler(this.buttonEquatCalc_Click);
            // 
            // chartEquat
            // 
            this.chartEquat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea9.InnerPlotPosition.Auto = false;
            chartArea9.InnerPlotPosition.Height = 85F;
            chartArea9.InnerPlotPosition.Width = 93F;
            chartArea9.InnerPlotPosition.X = 5F;
            chartArea9.InnerPlotPosition.Y = 5F;
            chartArea9.Name = "ChartArea1";
            this.chartEquat.ChartAreas.Add(chartArea9);
            this.chartEquat.Location = new System.Drawing.Point(62, 0);
            this.chartEquat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartEquat.Name = "chartEquat";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Crimson;
            series9.Name = "Series1";
            this.chartEquat.Series.Add(series9);
            this.chartEquat.Size = new System.Drawing.Size(688, 306);
            this.chartEquat.TabIndex = 0;
            this.chartEquat.Text = "chart1";
            title9.DockingOffset = 2;
            title9.Font = new System.Drawing.Font("Arial", 11F);
            title9.Name = "Title1";
            title9.Text = "F(x) = Ln(x) - (4-x)^0,5";
            title9.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartEquat.Titles.Add(title9);
            // 
            // buttonEquatBackToMenu
            // 
            this.buttonEquatBackToMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEquatBackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonEquatBackToMenu.BackgroundImage")));
            this.buttonEquatBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonEquatBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquatBackToMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEquatBackToMenu.FlatAppearance.BorderSize = 0;
            this.buttonEquatBackToMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEquatBackToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonEquatBackToMenu.Location = new System.Drawing.Point(9, 10);
            this.buttonEquatBackToMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEquatBackToMenu.Name = "buttonEquatBackToMenu";
            this.buttonEquatBackToMenu.Size = new System.Drawing.Size(22, 24);
            this.buttonEquatBackToMenu.TabIndex = 9;
            this.buttonEquatBackToMenu.UseVisualStyleBackColor = false;
            this.buttonEquatBackToMenu.Click += new System.EventHandler(this.buttonEquatBackToMenu_Click);
            // 
            // groupBoxInputEquatDataForCreateChart
            // 
            this.groupBoxInputEquatDataForCreateChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxInputEquatDataForCreateChart.Controls.Add(this.InputEquatChartN);
            this.groupBoxInputEquatDataForCreateChart.Controls.Add(this.label7);
            this.groupBoxInputEquatDataForCreateChart.Controls.Add(this.buttonEquatCreateChart);
            this.groupBoxInputEquatDataForCreateChart.Controls.Add(this.InputEquatChartB);
            this.groupBoxInputEquatDataForCreateChart.Controls.Add(this.label8);
            this.groupBoxInputEquatDataForCreateChart.Controls.Add(this.InputEquatChartA);
            this.groupBoxInputEquatDataForCreateChart.Controls.Add(this.label9);
            this.groupBoxInputEquatDataForCreateChart.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputEquatDataForCreateChart.Location = new System.Drawing.Point(413, 309);
            this.groupBoxInputEquatDataForCreateChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInputEquatDataForCreateChart.Name = "groupBoxInputEquatDataForCreateChart";
            this.groupBoxInputEquatDataForCreateChart.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInputEquatDataForCreateChart.Size = new System.Drawing.Size(388, 211);
            this.groupBoxInputEquatDataForCreateChart.TabIndex = 2;
            this.groupBoxInputEquatDataForCreateChart.TabStop = false;
            this.groupBoxInputEquatDataForCreateChart.Text = "Построение графика функции";
            // 
            // InputEquatChartN
            // 
            this.InputEquatChartN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatChartN.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatChartN.Location = new System.Drawing.Point(260, 78);
            this.InputEquatChartN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputEquatChartN.Name = "InputEquatChartN";
            this.InputEquatChartN.Size = new System.Drawing.Size(30, 23);
            this.InputEquatChartN.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(90, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество делений  = ";
            // 
            // buttonEquatCreateChart
            // 
            this.buttonEquatCreateChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEquatCreateChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquatCreateChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEquatCreateChart.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonEquatCreateChart.ForeColor = System.Drawing.Color.White;
            this.buttonEquatCreateChart.Location = new System.Drawing.Point(140, 136);
            this.buttonEquatCreateChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEquatCreateChart.Name = "buttonEquatCreateChart";
            this.buttonEquatCreateChart.Size = new System.Drawing.Size(100, 45);
            this.buttonEquatCreateChart.TabIndex = 8;
            this.buttonEquatCreateChart.Text = "Построить график";
            this.buttonEquatCreateChart.UseVisualStyleBackColor = false;
            this.buttonEquatCreateChart.Click += new System.EventHandler(this.buttonEquatCreateChart_Click);
            // 
            // InputEquatChartB
            // 
            this.InputEquatChartB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatChartB.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatChartB.Location = new System.Drawing.Point(260, 36);
            this.InputEquatChartB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputEquatChartB.Name = "InputEquatChartB";
            this.InputEquatChartB.Size = new System.Drawing.Size(30, 23);
            this.InputEquatChartB.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(92, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Интервал от ";
            // 
            // InputEquatChartA
            // 
            this.InputEquatChartA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatChartA.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatChartA.Location = new System.Drawing.Point(191, 36);
            this.InputEquatChartA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputEquatChartA.Name = "InputEquatChartA";
            this.InputEquatChartA.Size = new System.Drawing.Size(30, 23);
            this.InputEquatChartA.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(228, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "до ";
            // 
            // Equat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(812, 531);
            this.Controls.Add(this.groupBoxInputEquatDataForCreateChart);
            this.Controls.Add(this.buttonEquatBackToMenu);
            this.Controls.Add(this.chartEquat);
            this.Controls.Add(this.groupBoxInputEquatDataForCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Equat";
            this.Text = "Программа №3";
            this.Load += new System.EventHandler(this.Equat_Load);
            this.groupBoxInputEquatDataForCalc.ResumeLayout(false);
            this.groupBoxInputEquatDataForCalc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEquat)).EndInit();
            this.groupBoxInputEquatDataForCreateChart.ResumeLayout(false);
            this.groupBoxInputEquatDataForCreateChart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox InputEquatX0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OutputEquatN;
        private System.Windows.Forms.TextBox OutputEquatRes;
        private System.Windows.Forms.TextBox InputEquatEps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxInputEquatDataForCalc;
        private System.Windows.Forms.Button buttonEquatResetTextBox;
        private System.Windows.Forms.Button buttonEquatCalc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEquat;
        private System.Windows.Forms.Button buttonEquatBackToMenu;
        private System.Windows.Forms.GroupBox groupBoxInputEquatDataForCreateChart;
        private System.Windows.Forms.TextBox InputEquatChartN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEquatCreateChart;
        private System.Windows.Forms.TextBox InputEquatChartB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox InputEquatChartA;
        private System.Windows.Forms.Label label9;
    }
}