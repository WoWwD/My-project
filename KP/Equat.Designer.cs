
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.N = new System.Windows.Forms.TextBox();
            this.Res = new System.Windows.Forms.TextBox();
            this.Eps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxInputEquatDataForCalc = new System.Windows.Forms.GroupBox();
            this.buttonResetTextbox = new System.Windows.Forms.Button();
            this.X0 = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chartEquat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonBackToMenu = new System.Windows.Forms.Button();
            this.groupBoxInputEquatDataForCalc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEquat)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ответ =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Количество итераций =";
            // 
            // N
            // 
            this.N.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.N.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.N.Cursor = System.Windows.Forms.Cursors.Default;
            this.N.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.N.Location = new System.Drawing.Point(252, 148);
            this.N.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.Size = new System.Drawing.Size(50, 27);
            this.N.TabIndex = 15;
            this.N.TabStop = false;
            // 
            // Res
            // 
            this.Res.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Res.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Res.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Res.Location = new System.Drawing.Point(97, 198);
            this.Res.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Res.Name = "Res";
            this.Res.ReadOnly = true;
            this.Res.Size = new System.Drawing.Size(205, 27);
            this.Res.TabIndex = 66;
            this.Res.TabStop = false;
            // 
            // Eps
            // 
            this.Eps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Eps.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Eps.Location = new System.Drawing.Point(127, 98);
            this.Eps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Eps.Name = "Eps";
            this.Eps.Size = new System.Drawing.Size(175, 27);
            this.Eps.TabIndex = 2;
            this.Eps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputEquatEps_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(5, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Точность =";
            // 
            // groupBoxInputEquatDataForCalc
            // 
            this.groupBoxInputEquatDataForCalc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.buttonResetTextbox);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.X0);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.buttonCalc);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.label9);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.Res);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.Eps);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.N);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.label6);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.label5);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.label4);
            this.groupBoxInputEquatDataForCalc.Font = new System.Drawing.Font("Baskerville Old Face", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputEquatDataForCalc.Location = new System.Drawing.Point(289, 381);
            this.groupBoxInputEquatDataForCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInputEquatDataForCalc.Name = "groupBoxInputEquatDataForCalc";
            this.groupBoxInputEquatDataForCalc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxInputEquatDataForCalc.Size = new System.Drawing.Size(517, 260);
            this.groupBoxInputEquatDataForCalc.TabIndex = 1;
            this.groupBoxInputEquatDataForCalc.TabStop = false;
            this.groupBoxInputEquatDataForCalc.Text = "Ввод значений";
            // 
            // buttonResetTextbox
            // 
            this.buttonResetTextbox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonResetTextbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResetTextbox.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonResetTextbox.FlatAppearance.BorderSize = 4;
            this.buttonResetTextbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonResetTextbox.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonResetTextbox.ForeColor = System.Drawing.Color.White;
            this.buttonResetTextbox.Location = new System.Drawing.Point(343, 170);
            this.buttonResetTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonResetTextbox.Name = "buttonResetTextbox";
            this.buttonResetTextbox.Size = new System.Drawing.Size(133, 55);
            this.buttonResetTextbox.TabIndex = 4;
            this.buttonResetTextbox.Text = "Сбросить";
            this.buttonResetTextbox.UseVisualStyleBackColor = false;
            this.buttonResetTextbox.Click += new System.EventHandler(this.buttonEquatResetTextBox_Click);
            // 
            // X0
            // 
            this.X0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.X0.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X0.Location = new System.Drawing.Point(175, 48);
            this.X0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.X0.Name = "X0";
            this.X0.Size = new System.Drawing.Size(127, 27);
            this.X0.TabIndex = 6;
            this.X0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputEquatX0_KeyPress);
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
            this.buttonCalc.Location = new System.Drawing.Point(343, 48);
            this.buttonCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(133, 55);
            this.buttonCalc.TabIndex = 3;
            this.buttonCalc.Text = "Рассчитать";
            this.buttonCalc.UseVisualStyleBackColor = false;
            this.buttonCalc.Click += new System.EventHandler(this.buttonEquatCalc_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Значение корня =";
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
            this.chartEquat.Location = new System.Drawing.Point(83, 0);
            this.chartEquat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartEquat.Name = "chartEquat";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Crimson;
            series1.Name = "Series1";
            this.chartEquat.Series.Add(series1);
            this.chartEquat.Size = new System.Drawing.Size(917, 377);
            this.chartEquat.TabIndex = 0;
            this.chartEquat.Text = "chart1";
            title1.DockingOffset = 2;
            title1.Font = new System.Drawing.Font("Arial", 11F);
            title1.Name = "Title1";
            title1.Text = "F(x) = Ln(x) - (4-x)^0,5";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartEquat.Titles.Add(title1);
            // 
            // buttonBackToMenu
            // 
            this.buttonBackToMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackToMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBackToMenu.BackgroundImage")));
            this.buttonBackToMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBackToMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBackToMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackToMenu.FlatAppearance.BorderSize = 0;
            this.buttonBackToMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackToMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBackToMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackToMenu.Name = "buttonBackToMenu";
            this.buttonBackToMenu.Size = new System.Drawing.Size(29, 30);
            this.buttonBackToMenu.TabIndex = 9;
            this.buttonBackToMenu.UseVisualStyleBackColor = false;
            this.buttonBackToMenu.Click += new System.EventHandler(this.buttonEquatBackToMenu_Click);
            // 
            // Equat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1083, 654);
            this.Controls.Add(this.buttonBackToMenu);
            this.Controls.Add(this.chartEquat);
            this.Controls.Add(this.groupBoxInputEquatDataForCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Equat";
            this.Text = "Программа №3";
            this.Load += new System.EventHandler(this.Equat_Load);
            this.groupBoxInputEquatDataForCalc.ResumeLayout(false);
            this.groupBoxInputEquatDataForCalc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEquat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox N;
        private System.Windows.Forms.TextBox Res;
        private System.Windows.Forms.TextBox Eps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxInputEquatDataForCalc;
        private System.Windows.Forms.Button buttonResetTextbox;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEquat;
        private System.Windows.Forms.Button buttonBackToMenu;
        private System.Windows.Forms.TextBox X0;
        private System.Windows.Forms.Label label9;
    }
}