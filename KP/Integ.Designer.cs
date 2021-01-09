
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
            this.LowLimit = new System.Windows.Forms.TextBox();
            this.UpLimit = new System.Windows.Forms.TextBox();
            this.Segments = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.chartInteg = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxIntegInputDataForCalc = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonResetTextbox = new System.Windows.Forms.Button();
            this.Eps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Res = new System.Windows.Forms.TextBox();
            this.buttonIntegBackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartInteg)).BeginInit();
            this.groupBoxIntegInputDataForCalc.SuspendLayout();
            this.SuspendLayout();
            // 
            // LowLimit
            // 
            this.LowLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LowLimit.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowLimit.Location = new System.Drawing.Point(195, 29);
            this.LowLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LowLimit.Name = "LowLimit";
            this.LowLimit.Size = new System.Drawing.Size(101, 27);
            this.LowLimit.TabIndex = 1;
            this.LowLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputIntegLowLimit_KeyPress);
            // 
            // UpLimit
            // 
            this.UpLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpLimit.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpLimit.Location = new System.Drawing.Point(195, 71);
            this.UpLimit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpLimit.Name = "UpLimit";
            this.UpLimit.Size = new System.Drawing.Size(101, 27);
            this.UpLimit.TabIndex = 2;
            this.UpLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputIntegUpLimit_KeyPress);
            // 
            // Segments
            // 
            this.Segments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Segments.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Segments.Location = new System.Drawing.Point(451, 71);
            this.Segments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Segments.Name = "Segments";
            this.Segments.Size = new System.Drawing.Size(146, 27);
            this.Segments.TabIndex = 3;
            this.Segments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputIntegSegments_KeyPress);
            // 
            // buttonCalc
            // 
            this.buttonCalc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCalc.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonCalc.FlatAppearance.BorderSize = 4;
            this.buttonCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCalc.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonCalc.ForeColor = System.Drawing.Color.White;
            this.buttonCalc.Location = new System.Drawing.Point(151, 186);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(133, 55);
            this.buttonCalc.TabIndex = 4;
            this.buttonCalc.Text = "Рассчитать";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonIntegCalc_Click);
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
            // groupBoxIntegInputDataForCalc
            // 
            this.groupBoxIntegInputDataForCalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.label5);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.buttonResetTextbox);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.Eps);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.buttonCalc);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.label4);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.label2);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.label3);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.label1);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.LowLimit);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.Res);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.UpLimit);
            this.groupBoxIntegInputDataForCalc.Controls.Add(this.Segments);
            this.groupBoxIntegInputDataForCalc.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxIntegInputDataForCalc.Location = new System.Drawing.Point(235, 381);
            this.groupBoxIntegInputDataForCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIntegInputDataForCalc.Name = "groupBoxIntegInputDataForCalc";
            this.groupBoxIntegInputDataForCalc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxIntegInputDataForCalc.Size = new System.Drawing.Size(617, 260);
            this.groupBoxIntegInputDataForCalc.TabIndex = 1;
            this.groupBoxIntegInputDataForCalc.TabStop = false;
            this.groupBoxIntegInputDataForCalc.Text = "Ввод значений";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(329, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Точность =";
            // 
            // buttonResetTextbox
            // 
            this.buttonResetTextbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonResetTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetTextbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResetTextbox.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonResetTextbox.ForeColor = System.Drawing.Color.White;
            this.buttonResetTextbox.Location = new System.Drawing.Point(324, 186);
            this.buttonResetTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonResetTextbox.Name = "buttonResetTextbox";
            this.buttonResetTextbox.Size = new System.Drawing.Size(133, 55);
            this.buttonResetTextbox.TabIndex = 5;
            this.buttonResetTextbox.Text = "Сбросить";
            this.buttonResetTextbox.UseVisualStyleBackColor = false;
            this.buttonResetTextbox.Click += new System.EventHandler(this.buttonIntegResetTextBox_Click);
            // 
            // Eps
            // 
            this.Eps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Eps.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eps.Location = new System.Drawing.Point(451, 29);
            this.Eps.Name = "Eps";
            this.Eps.Size = new System.Drawing.Size(146, 27);
            this.Eps.TabIndex = 11;
            this.Eps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputIntegEps_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(147, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ответ =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Верхний предел  =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(329, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Сегменты =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Нижний предел  =";
            // 
            // Res
            // 
            this.Res.BackColor = System.Drawing.SystemColors.Window;
            this.Res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Res.Cursor = System.Windows.Forms.Cursors.Default;
            this.Res.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res.Location = new System.Drawing.Point(237, 124);
            this.Res.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Res.Name = "Res";
            this.Res.ReadOnly = true;
            this.Res.Size = new System.Drawing.Size(220, 27);
            this.Res.TabIndex = 3;
            this.Res.TabStop = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox LowLimit;
        private System.Windows.Forms.TextBox UpLimit;
        private System.Windows.Forms.TextBox Segments;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartInteg;
        private System.Windows.Forms.GroupBox groupBoxIntegInputDataForCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Res;
        private System.Windows.Forms.Button buttonResetTextbox;
        private System.Windows.Forms.Button buttonIntegBackToMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Eps;
    }
}