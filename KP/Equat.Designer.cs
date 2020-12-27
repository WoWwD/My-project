
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.InputEquatX0.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatX0.Location = new System.Drawing.Point(158, 38);
            this.InputEquatX0.Name = "InputEquatX0";
            this.InputEquatX0.Size = new System.Drawing.Size(125, 24);
            this.InputEquatX0.TabIndex = 1;
            this.InputEquatX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputEquatX0_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Значение корня =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ответ = ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество итераций = ";
            // 
            // OutputEquatN
            // 
            this.OutputEquatN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputEquatN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputEquatN.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputEquatN.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputEquatN.Location = new System.Drawing.Point(193, 118);
            this.OutputEquatN.Name = "OutputEquatN";
            this.OutputEquatN.ReadOnly = true;
            this.OutputEquatN.Size = new System.Drawing.Size(90, 24);
            this.OutputEquatN.TabIndex = 15;
            this.OutputEquatN.TabStop = false;
            // 
            // OutputEquatRes
            // 
            this.OutputEquatRes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputEquatRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputEquatRes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputEquatRes.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputEquatRes.Location = new System.Drawing.Point(83, 158);
            this.OutputEquatRes.Name = "OutputEquatRes";
            this.OutputEquatRes.ReadOnly = true;
            this.OutputEquatRes.Size = new System.Drawing.Size(200, 24);
            this.OutputEquatRes.TabIndex = 66;
            this.OutputEquatRes.TabStop = false;
            // 
            // InputEquatEps
            // 
            this.InputEquatEps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatEps.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatEps.Location = new System.Drawing.Point(104, 78);
            this.InputEquatEps.Name = "InputEquatEps";
            this.InputEquatEps.Size = new System.Drawing.Size(179, 24);
            this.InputEquatEps.TabIndex = 2;
            this.InputEquatEps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputEquatEps_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
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
            this.groupBoxInputEquatDataForCalc.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputEquatDataForCalc.Location = new System.Drawing.Point(12, 365);
            this.groupBoxInputEquatDataForCalc.Name = "groupBoxInputEquatDataForCalc";
            this.groupBoxInputEquatDataForCalc.Size = new System.Drawing.Size(450, 216);
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
            this.buttonEquatResetTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonEquatResetTextBox.ForeColor = System.Drawing.Color.White;
            this.buttonEquatResetTextBox.Location = new System.Drawing.Point(308, 132);
            this.buttonEquatResetTextBox.Name = "buttonEquatResetTextBox";
            this.buttonEquatResetTextBox.Size = new System.Drawing.Size(124, 50);
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
            this.buttonEquatCalc.Font = new System.Drawing.Font("Baskerville Old Face", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonEquatCalc.ForeColor = System.Drawing.Color.White;
            this.buttonEquatCalc.Location = new System.Drawing.Point(308, 38);
            this.buttonEquatCalc.Name = "buttonEquatCalc";
            this.buttonEquatCalc.Size = new System.Drawing.Size(124, 50);
            this.buttonEquatCalc.TabIndex = 3;
            this.buttonEquatCalc.Text = "Рассчитать";
            this.buttonEquatCalc.UseVisualStyleBackColor = false;
            this.buttonEquatCalc.Click += new System.EventHandler(this.buttonEquatCalc_Click);
            // 
            // chartEquat
            // 
            this.chartEquat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 85F;
            chartArea1.InnerPlotPosition.Width = 93F;
            chartArea1.InnerPlotPosition.X = 5F;
            chartArea1.InnerPlotPosition.Y = 5F;
            chartArea1.Name = "ChartArea1";
            this.chartEquat.ChartAreas.Add(chartArea1);
            this.chartEquat.Location = new System.Drawing.Point(12, 0);
            this.chartEquat.Name = "chartEquat";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Crimson;
            series1.Name = "Series1";
            this.chartEquat.Series.Add(series1);
            this.chartEquat.Size = new System.Drawing.Size(918, 360);
            this.chartEquat.TabIndex = 0;
            this.chartEquat.Text = "chart1";
            title1.DockingOffset = 2;
            title1.Font = new System.Drawing.Font("Arial", 11F);
            title1.Name = "Title1";
            title1.Text = "F(x) = Ln(x) - (4-x)^0,5";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartEquat.Titles.Add(title1);
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
            this.buttonEquatBackToMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonEquatBackToMenu.Name = "buttonEquatBackToMenu";
            this.buttonEquatBackToMenu.Size = new System.Drawing.Size(30, 30);
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
            this.groupBoxInputEquatDataForCreateChart.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputEquatDataForCreateChart.Location = new System.Drawing.Point(480, 365);
            this.groupBoxInputEquatDataForCreateChart.Name = "groupBoxInputEquatDataForCreateChart";
            this.groupBoxInputEquatDataForCreateChart.Size = new System.Drawing.Size(450, 216);
            this.groupBoxInputEquatDataForCreateChart.TabIndex = 2;
            this.groupBoxInputEquatDataForCreateChart.TabStop = false;
            this.groupBoxInputEquatDataForCreateChart.Text = "Построение графика функции";
            // 
            // InputEquatChartN
            // 
            this.InputEquatChartN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatChartN.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatChartN.Location = new System.Drawing.Point(298, 95);
            this.InputEquatChartN.Name = "InputEquatChartN";
            this.InputEquatChartN.Size = new System.Drawing.Size(40, 24);
            this.InputEquatChartN.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(104, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество делений  = ";
            // 
            // buttonEquatCreateChart
            // 
            this.buttonEquatCreateChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEquatCreateChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquatCreateChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEquatCreateChart.Font = new System.Drawing.Font("Baskerville Old Face", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonEquatCreateChart.ForeColor = System.Drawing.Color.White;
            this.buttonEquatCreateChart.Location = new System.Drawing.Point(155, 143);
            this.buttonEquatCreateChart.Name = "buttonEquatCreateChart";
            this.buttonEquatCreateChart.Size = new System.Drawing.Size(124, 50);
            this.buttonEquatCreateChart.TabIndex = 8;
            this.buttonEquatCreateChart.Text = "Построить график";
            this.buttonEquatCreateChart.UseVisualStyleBackColor = false;
            this.buttonEquatCreateChart.Click += new System.EventHandler(this.buttonEquatCreateChart_Click);
            // 
            // InputEquatChartB
            // 
            this.InputEquatChartB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatChartB.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatChartB.Location = new System.Drawing.Point(298, 38);
            this.InputEquatChartB.Name = "InputEquatChartB";
            this.InputEquatChartB.Size = new System.Drawing.Size(40, 24);
            this.InputEquatChartB.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(104, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Интервал от ";
            // 
            // InputEquatChartA
            // 
            this.InputEquatChartA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatChartA.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatChartA.Location = new System.Drawing.Point(212, 38);
            this.InputEquatChartA.Name = "InputEquatChartA";
            this.InputEquatChartA.Size = new System.Drawing.Size(40, 24);
            this.InputEquatChartA.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(258, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "до ";
            // 
            // Equat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(942, 593);
            this.Controls.Add(this.groupBoxInputEquatDataForCreateChart);
            this.Controls.Add(this.buttonEquatBackToMenu);
            this.Controls.Add(this.chartEquat);
            this.Controls.Add(this.groupBoxInputEquatDataForCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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