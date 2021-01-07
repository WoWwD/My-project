
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equat));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.OutputEquatN = new System.Windows.Forms.TextBox();
            this.OutputEquatRes = new System.Windows.Forms.TextBox();
            this.InputEquatEps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxInputEquatDataForCalc = new System.Windows.Forms.GroupBox();
            this.buttonEquatResetTextBox = new System.Windows.Forms.Button();
            this.InputEquatX0 = new System.Windows.Forms.TextBox();
            this.buttonEquatCalc = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chartEquat = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonEquatBackToMenu = new System.Windows.Forms.Button();
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
            // OutputEquatN
            // 
            this.OutputEquatN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputEquatN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputEquatN.Cursor = System.Windows.Forms.Cursors.Default;
            this.OutputEquatN.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputEquatN.Location = new System.Drawing.Point(252, 148);
            this.OutputEquatN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputEquatN.Name = "OutputEquatN";
            this.OutputEquatN.ReadOnly = true;
            this.OutputEquatN.Size = new System.Drawing.Size(50, 27);
            this.OutputEquatN.TabIndex = 15;
            this.OutputEquatN.TabStop = false;
            // 
            // OutputEquatRes
            // 
            this.OutputEquatRes.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OutputEquatRes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputEquatRes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OutputEquatRes.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OutputEquatRes.Location = new System.Drawing.Point(97, 198);
            this.OutputEquatRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputEquatRes.Name = "OutputEquatRes";
            this.OutputEquatRes.ReadOnly = true;
            this.OutputEquatRes.Size = new System.Drawing.Size(205, 27);
            this.OutputEquatRes.TabIndex = 66;
            this.OutputEquatRes.TabStop = false;
            // 
            // InputEquatEps
            // 
            this.InputEquatEps.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatEps.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatEps.Location = new System.Drawing.Point(127, 98);
            this.InputEquatEps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputEquatEps.Name = "InputEquatEps";
            this.InputEquatEps.Size = new System.Drawing.Size(175, 27);
            this.InputEquatEps.TabIndex = 2;
            this.InputEquatEps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputEquatEps_KeyPress);
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
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.buttonEquatResetTextBox);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.InputEquatX0);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.buttonEquatCalc);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.label9);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.OutputEquatRes);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.InputEquatEps);
            this.groupBoxInputEquatDataForCalc.Controls.Add(this.OutputEquatN);
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
            // buttonEquatResetTextBox
            // 
            this.buttonEquatResetTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEquatResetTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquatResetTextBox.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonEquatResetTextBox.FlatAppearance.BorderSize = 4;
            this.buttonEquatResetTextBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEquatResetTextBox.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.buttonEquatResetTextBox.ForeColor = System.Drawing.Color.White;
            this.buttonEquatResetTextBox.Location = new System.Drawing.Point(343, 170);
            this.buttonEquatResetTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEquatResetTextBox.Name = "buttonEquatResetTextBox";
            this.buttonEquatResetTextBox.Size = new System.Drawing.Size(133, 55);
            this.buttonEquatResetTextBox.TabIndex = 4;
            this.buttonEquatResetTextBox.Text = "Сбросить";
            this.buttonEquatResetTextBox.UseVisualStyleBackColor = false;
            this.buttonEquatResetTextBox.Click += new System.EventHandler(this.buttonEquatResetTextBox_Click);
            // 
            // InputEquatX0
            // 
            this.InputEquatX0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InputEquatX0.Font = new System.Drawing.Font("Baskerville Old Face", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InputEquatX0.Location = new System.Drawing.Point(175, 48);
            this.InputEquatX0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputEquatX0.Name = "InputEquatX0";
            this.InputEquatX0.Size = new System.Drawing.Size(127, 27);
            this.InputEquatX0.TabIndex = 6;
            this.InputEquatX0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputEquatX0_KeyPress);
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
            this.buttonEquatCalc.Location = new System.Drawing.Point(343, 48);
            this.buttonEquatCalc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEquatCalc.Name = "buttonEquatCalc";
            this.buttonEquatCalc.Size = new System.Drawing.Size(133, 55);
            this.buttonEquatCalc.TabIndex = 3;
            this.buttonEquatCalc.Text = "Рассчитать";
            this.buttonEquatCalc.UseVisualStyleBackColor = false;
            this.buttonEquatCalc.Click += new System.EventHandler(this.buttonEquatCalc_Click);
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
            chartArea7.InnerPlotPosition.Auto = false;
            chartArea7.InnerPlotPosition.Height = 85F;
            chartArea7.InnerPlotPosition.Width = 93F;
            chartArea7.InnerPlotPosition.X = 5F;
            chartArea7.InnerPlotPosition.Y = 5F;
            chartArea7.Name = "ChartArea1";
            this.chartEquat.ChartAreas.Add(chartArea7);
            this.chartEquat.Location = new System.Drawing.Point(83, 0);
            this.chartEquat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartEquat.Name = "chartEquat";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Color = System.Drawing.Color.Crimson;
            series7.Name = "Series1";
            this.chartEquat.Series.Add(series7);
            this.chartEquat.Size = new System.Drawing.Size(917, 377);
            this.chartEquat.TabIndex = 0;
            this.chartEquat.Text = "chart1";
            title7.DockingOffset = 2;
            title7.Font = new System.Drawing.Font("Arial", 11F);
            title7.Name = "Title1";
            title7.Text = "F(x) = Ln(x) - (4-x)^0,5";
            title7.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.chartEquat.Titles.Add(title7);
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
            this.buttonEquatBackToMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEquatBackToMenu.Name = "buttonEquatBackToMenu";
            this.buttonEquatBackToMenu.Size = new System.Drawing.Size(29, 30);
            this.buttonEquatBackToMenu.TabIndex = 9;
            this.buttonEquatBackToMenu.UseVisualStyleBackColor = false;
            this.buttonEquatBackToMenu.Click += new System.EventHandler(this.buttonEquatBackToMenu_Click);
            // 
            // Equat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1083, 654);
            this.Controls.Add(this.buttonEquatBackToMenu);
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
        private System.Windows.Forms.TextBox OutputEquatN;
        private System.Windows.Forms.TextBox OutputEquatRes;
        private System.Windows.Forms.TextBox InputEquatEps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxInputEquatDataForCalc;
        private System.Windows.Forms.Button buttonEquatResetTextBox;
        private System.Windows.Forms.Button buttonEquatCalc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEquat;
        private System.Windows.Forms.Button buttonEquatBackToMenu;
        private System.Windows.Forms.TextBox InputEquatX0;
        private System.Windows.Forms.Label label9;
    }
}