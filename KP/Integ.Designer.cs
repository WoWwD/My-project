
namespace KP
{
    partial class Integ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Integ));
            this.InputIntegLowLimit = new System.Windows.Forms.TextBox();
            this.InputIntegUpLimit = new System.Windows.Forms.TextBox();
            this.InputIntegSegments = new System.Windows.Forms.TextBox();
            this.buttonIntegCalc = new System.Windows.Forms.Button();
            this.chartInteg = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonIntegCreateChart = new System.Windows.Forms.Button();
            this.groupBoxIntegInputDataForCalc = new System.Windows.Forms.GroupBox();
            this.buttonIntegResetTextBox = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OutputIntegCalc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InputIntegChartA = new System.Windows.Forms.TextBox();
            this.InputIntegChartB = new System.Windows.Forms.TextBox();
            this.groupBoxInputIntegDataForCreateChart = new System.Windows.Forms.GroupBox();
            this.InputIntegChartN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonIntegBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartInteg)).BeginInit();
            this.groupBoxIntegInputDataForCalc.SuspendLayout();
            this.groupBoxInputIntegDataForCreateChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputIntegLowLimit
            // 
            this.InputIntegLowLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputIntegLowLimit.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputIntegLowLimit.Location = new System.Drawing.Point(185, 47);
            this.InputIntegLowLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputIntegLowLimit.Name = "InputIntegLowLimit";
            this.InputIntegLowLimit.Size = new System.Drawing.Size(101, 27);
            this.InputIntegLowLimit.TabIndex = 1;
            this.InputIntegLowLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputIntegLowLimit_KeyPress);
            // 
            // InputIntegUpLimit
            // 
            this.InputIntegUpLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputIntegUpLimit.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputIntegUpLimit.Location = new System.Drawing.Point(185, 96);
            this.InputIntegUpLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputIntegUpLimit.Name = "InputIntegUpLimit";
            this.InputIntegUpLimit.Size = new System.Drawing.Size(101, 27);
            this.InputIntegUpLimit.TabIndex = 2;
            this.InputIntegUpLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputIntegUpLimit_KeyPress);
            // 
            // InputIntegSegments
            // 
            this.InputIntegSegments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputIntegSegments.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputIntegSegments.Location = new System.Drawing.Point(140, 145);
            this.InputIntegSegments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputIntegSegments.Name = "InputIntegSegments";
            this.InputIntegSegments.Size = new System.Drawing.Size(146, 27);
            this.InputIntegSegments.TabIndex = 3;
            // 
            // buttonIntegCalc
            // 
            this.buttonIntegCalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonIntegCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIntegCalc.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonIntegCalc.FlatAppearance.BorderSize = 4;
            this.buttonIntegCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIntegCalc.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonIntegCalc.ForeColor = System.Drawing.Color.White;
            this.buttonIntegCalc.Location = new System.Drawing.Point(343, 47);
            this.buttonIntegCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIntegCalc.Name = "buttonIntegCalc";
            this.buttonIntegCalc.Size = new System.Drawing.Size(133, 55);
            this.buttonIntegCalc.TabIndex = 4;
            this.buttonIntegCalc.Text = "Рассчитать";
            this.buttonIntegCalc.UseVisualStyleBackColor = false;
            this.buttonIntegCalc.Click += new System.EventHandler(this.buttonIntegCalc_Click);
            // 
            // chartInteg
            // 
            this.chartInteg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chartInteg.BorderlineWidth = 0;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 85F;
            chartArea1.InnerPlotPosition.Width = 93F;
            chartArea1.InnerPlotPosition.X = 5F;
            chartArea1.InnerPlotPosition.Y = 5F;
            chartArea1.Name = "ChartArea1";
            this.chartInteg.ChartAreas.Add(chartArea1);
            this.chartInteg.Location = new System.Drawing.Point(83, 0);
            this.chartInteg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartInteg.Name = "chartInteg";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Crimson;
            series1.Name = "Series";
            this.chartInteg.Series.Add(series1);
            this.chartInteg.Size = new System.Drawing.Size(917, 377);
            this.chartInteg.TabIndex = 0;
            this.chartInteg.Text = "chart1";
            title1.DockingOffset = 2;
            title1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title1.Name = "Title1";
            title1.Text = "F(x) = Cos(x^0,5)";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartInteg.Titles.Add(title1);
            // 
            // buttonIntegCreateChart
            // 
            this.buttonIntegCreateChart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonIntegCreateChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIntegCreateChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIntegCreateChart.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonIntegCreateChart.ForeColor = System.Drawing.Color.White;
            this.buttonIntegCreateChart.Location = new System.Drawing.Point(187, 167);
            this.buttonIntegCreateChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIntegCreateChart.Name = "buttonIntegCreateChart";
            this.buttonIntegCreateChart.Size = new System.Drawing.Size(133, 55);
            this.buttonIntegCreateChart.TabIndex = 9;
            this.buttonIntegCreateChart.Text = "Построить график";
            this.buttonIntegCreateChart.UseVisualStyleBackColor = false;
            this.buttonIntegCreateChart.Click += new System.EventHandler(this.buttonIntegCreateChart_Click);
            // 
            // groupBoxIntegInputDataForCalc
            // 
            this.groupBoxIntegInputDataForCalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.buttonIntegResetTextBox);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.label4);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.label2);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.label3);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.label1);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.InputIntegLowLimit);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.OutputIntegCalc);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.buttonIntegCalc);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.InputIntegUpLimit);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.InputIntegSegments);
            this.groupBoxIntegInputDataForCalc.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxIntegInputDataForCalc.Location = new System.Drawing.Point(15, 382);
            this.groupBoxIntegInputDataForCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIntegInputDataForCalc.Name = "groupBoxIntegInputDataForCalc";
            this.groupBoxIntegInputDataForCalc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIntegInputDataForCalc.Size = new System.Drawing.Size(517, 260);
            this.groupBoxIntegInputDataForCalc.TabIndex = 1;
            this.groupBoxIntegInputDataForCalc.TabStop = false;
            this.groupBoxIntegInputDataForCalc.Text = "Ввод значений";
            // 
            // buttonIntegResetTextBox
            // 
            this.buttonIntegResetTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonIntegResetTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIntegResetTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonIntegResetTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonIntegResetTextBox.ForeColor = System.Drawing.Color.White;
            this.buttonIntegResetTextBox.Location = new System.Drawing.Point(343, 167);
            this.buttonIntegResetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIntegResetTextBox.Name = "buttonIntegResetTextBox";
            this.buttonIntegResetTextBox.Size = new System.Drawing.Size(133, 55);
            this.buttonIntegResetTextBox.TabIndex = 5;
            this.buttonIntegResetTextBox.Text = "Сбросить";
            this.buttonIntegResetTextBox.UseVisualStyleBackColor = false;
            this.buttonIntegResetTextBox.Click += new System.EventHandler(this.buttonIntegResetTextBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ответ =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(5, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Верхний предел  =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сегменты = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нижний предел  = ";
            // 
            // OutputIntegCalc
            // 
            this.OutputIntegCalc.BackColor = System.Drawing.SystemColors.Window;
            this.OutputIntegCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputIntegCalc.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputIntegCalc.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputIntegCalc.Location = new System.Drawing.Point(99, 194);
            this.OutputIntegCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputIntegCalc.Name = "OutputIntegCalc";
            this.OutputIntegCalc.ReadOnly = true;
            this.OutputIntegCalc.Size = new System.Drawing.Size(187, 27);
            this.OutputIntegCalc.TabIndex = 3;
            this.OutputIntegCalc.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(123, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Интервал от ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(304, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "до ";
            // 
            // InputIntegChartA
            // 
            this.InputIntegChartA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputIntegChartA.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputIntegChartA.Location = new System.Drawing.Point(255, 47);
            this.InputIntegChartA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputIntegChartA.Name = "InputIntegChartA";
            this.InputIntegChartA.Size = new System.Drawing.Size(39, 27);
            this.InputIntegChartA.TabIndex = 6;
            this.InputIntegChartA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputIntegChartA_KeyPress);
            // 
            // InputIntegChartB
            // 
            this.InputIntegChartB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputIntegChartB.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputIntegChartB.Location = new System.Drawing.Point(347, 47);
            this.InputIntegChartB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputIntegChartB.Name = "InputIntegChartB";
            this.InputIntegChartB.Size = new System.Drawing.Size(39, 27);
            this.InputIntegChartB.TabIndex = 7;
            this.InputIntegChartB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputIntegChartB_KeyPress);
            // 
            // groupBoxInputIntegDataForCreateChart
            // 
            this.groupBoxInputIntegDataForCreateChart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxInputIntegDataForCreateChart.Controls.Add(this.InputIntegChartN);
            this.groupBoxInputIntegDataForCreateChart.Controls.Add(this.label7);
            this.groupBoxInputIntegDataForCreateChart.Controls.Add(this.buttonIntegCreateChart);
            this.groupBoxInputIntegDataForCreateChart.Controls.Add(this.InputIntegChartB);
            this.groupBoxInputIntegDataForCreateChart.Controls.Add(this.label5);
            this.groupBoxInputIntegDataForCreateChart.Controls.Add(this.InputIntegChartA);
            this.groupBoxInputIntegDataForCreateChart.Controls.Add(this.label6);
            this.groupBoxInputIntegDataForCreateChart.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputIntegDataForCreateChart.Location = new System.Drawing.Point(549, 382);
            this.groupBoxInputIntegDataForCreateChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInputIntegDataForCreateChart.Name = "groupBoxInputIntegDataForCreateChart";
            this.groupBoxInputIntegDataForCreateChart.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInputIntegDataForCreateChart.Size = new System.Drawing.Size(519, 260);
            this.groupBoxInputIntegDataForCreateChart.TabIndex = 2;
            this.groupBoxInputIntegDataForCreateChart.TabStop = false;
            this.groupBoxInputIntegDataForCreateChart.Text = "Построение графика подынтегральной функции";
            // 
            // InputIntegChartN
            // 
            this.InputIntegChartN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputIntegChartN.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputIntegChartN.Location = new System.Drawing.Point(347, 96);
            this.InputIntegChartN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputIntegChartN.Name = "InputIntegChartN";
            this.InputIntegChartN.Size = new System.Drawing.Size(39, 27);
            this.InputIntegChartN.TabIndex = 8;
            this.InputIntegChartN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputIntegChartN_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(123, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество делений  = ";
            // 
            // buttonIntegBackToMenu
            // 
            this.buttonIntegBackToMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIntegBackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIntegBackToMenu.BackgroundImage")));
            this.buttonIntegBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonIntegBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIntegBackToMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIntegBackToMenu.FlatAppearance.BorderSize = 0;
            this.buttonIntegBackToMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIntegBackToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonIntegBackToMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonIntegBackToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIntegBackToMenu.Name = "buttonIntegBackToMenu";
            this.buttonIntegBackToMenu.Size = new System.Drawing.Size(29, 30);
            this.buttonIntegBackToMenu.TabIndex = 10;
            this.buttonIntegBackToMenu.UseVisualStyleBackColor = false;
            this.buttonIntegBackToMenu.Click += new System.EventHandler(this.buttonIntegBackToMenu_Click);
            // 
            // Integ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1083, 654);
            this.Controls.Add(this.buttonIntegBackToMenu);
            this.Controls.Add(this.groupBoxInputIntegDataForCreateChart);
            this.Controls.Add(this.groupBoxIntegInputDataForCalc);
            this.Controls.Add(this.chartInteg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Integ";
            this.Text = "Программа №2";
            this.Load += new System.EventHandler(this.Integ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartInteg)).EndInit();
            this.groupBoxIntegInputDataForCalc.ResumeLayout(false);
            this.groupBoxIntegInputDataForCalc.PerformLayout();
            this.groupBoxInputIntegDataForCreateChart.ResumeLayout(false);
            this.groupBoxInputIntegDataForCreateChart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InputIntegLowLimit;
        private System.Windows.Forms.TextBox InputIntegUpLimit;
        private System.Windows.Forms.TextBox InputIntegSegments;
        private System.Windows.Forms.Button buttonIntegCalc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInteg;
        private System.Windows.Forms.Button buttonIntegCreateChart;
        private System.Windows.Forms.GroupBox groupBoxIntegInputDataForCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OutputIntegCalc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox InputIntegChartA;
        private System.Windows.Forms.TextBox InputIntegChartB;
        private System.Windows.Forms.GroupBox groupBoxInputIntegDataForCreateChart;
        private System.Windows.Forms.TextBox InputIntegChartN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonIntegResetTextBox;
        private System.Windows.Forms.Button buttonIntegBackToMenu;
    }
}