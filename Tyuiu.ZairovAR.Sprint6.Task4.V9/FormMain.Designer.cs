namespace Tyuiu.ZairovAR.Sprint6.Task4.V9
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBoxTask_ZAR = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.panelF = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData_ZAR = new System.Windows.Forms.GroupBox();
            this.labelInputStopStep_ZAR = new System.Windows.Forms.Label();
            this.labelInputStartStep_ZAR = new System.Windows.Forms.Label();
            this.textBoxInputStopStep_ZAR = new System.Windows.Forms.TextBox();
            this.textBoxInputStartStep_ZAR = new System.Windows.Forms.TextBox();
            this.buttonStartCode_ZAR = new System.Windows.Forms.Button();
            this.buttonSpravka_ZAR = new System.Windows.Forms.Button();
            this.buttonSave_ZAR = new System.Windows.Forms.Button();
            this.groupBoxOutputData_ZAR = new System.Windows.Forms.GroupBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.chart_ZAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel.SuspendLayout();
            this.groupBoxTask_ZAR.SuspendLayout();
            this.panelStatistic.SuspendLayout();
            this.panelF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxInputData_ZAR.SuspendLayout();
            this.groupBoxOutputData_ZAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ZAR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Menu;
            this.panel.Controls.Add(this.buttonSpravka_ZAR);
            this.panel.Controls.Add(this.buttonSave_ZAR);
            this.panel.Controls.Add(this.buttonStartCode_ZAR);
            this.panel.Controls.Add(this.groupBoxInputData_ZAR);
            this.panel.Controls.Add(this.groupBoxTask_ZAR);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1154, 100);
            this.panel.TabIndex = 0;
            // 
            // groupBoxTask_ZAR
            // 
            this.groupBoxTask_ZAR.Controls.Add(this.pictureBox1);
            this.groupBoxTask_ZAR.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_ZAR.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_ZAR.Name = "groupBoxTask_ZAR";
            this.groupBoxTask_ZAR.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_ZAR.Size = new System.Drawing.Size(509, 91);
            this.groupBoxTask_ZAR.TabIndex = 3;
            this.groupBoxTask_ZAR.TabStop = false;
            this.groupBoxTask_ZAR.Text = "Условие";
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Location = new System.Drawing.Point(6, 17);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(497, 61);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = "Протабулироавать функцию:\r\n\r\nна заданном диапазоне. Результат вывести в TextBox, " +
    "построить график функции и сохранить в файл OutPutFileTask4V9.txt по нажатию кно" +
    "пки.";
            // 
            // panelStatistic
            // 
            this.panelStatistic.BackColor = System.Drawing.SystemColors.Menu;
            this.panelStatistic.Controls.Add(this.groupBoxOutputData_ZAR);
            this.panelStatistic.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatistic.Location = new System.Drawing.Point(0, 100);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(200, 496);
            this.panelStatistic.TabIndex = 0;
            // 
            // panelF
            // 
            this.panelF.BackColor = System.Drawing.SystemColors.Menu;
            this.panelF.Controls.Add(this.chart_ZAR);
            this.panelF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelF.Location = new System.Drawing.Point(200, 100);
            this.panelF.Name = "panelF";
            this.panelF.Size = new System.Drawing.Size(954, 496);
            this.panelF.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(200, 100);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 496);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.ZairovAR.Sprint6.Task4.V9.Properties.Resources.Screenshot_10;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(176, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 40);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBoxInputData_ZAR
            // 
            this.groupBoxInputData_ZAR.Controls.Add(this.labelInputStopStep_ZAR);
            this.groupBoxInputData_ZAR.Controls.Add(this.labelInputStartStep_ZAR);
            this.groupBoxInputData_ZAR.Controls.Add(this.textBoxInputStopStep_ZAR);
            this.groupBoxInputData_ZAR.Controls.Add(this.textBoxInputStartStep_ZAR);
            this.groupBoxInputData_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_ZAR.Location = new System.Drawing.Point(518, 12);
            this.groupBoxInputData_ZAR.Name = "groupBoxInputData_ZAR";
            this.groupBoxInputData_ZAR.Size = new System.Drawing.Size(240, 81);
            this.groupBoxInputData_ZAR.TabIndex = 5;
            this.groupBoxInputData_ZAR.TabStop = false;
            this.groupBoxInputData_ZAR.Text = "Ввод данных";
            // 
            // labelInputStopStep_ZAR
            // 
            this.labelInputStopStep_ZAR.AutoSize = true;
            this.labelInputStopStep_ZAR.Location = new System.Drawing.Point(131, 35);
            this.labelInputStopStep_ZAR.Name = "labelInputStopStep_ZAR";
            this.labelInputStopStep_ZAR.Size = new System.Drawing.Size(76, 15);
            this.labelInputStopStep_ZAR.TabIndex = 3;
            this.labelInputStopStep_ZAR.Text = "Конец шага:";
            // 
            // labelInputStartStep_ZAR
            // 
            this.labelInputStartStep_ZAR.AutoSize = true;
            this.labelInputStartStep_ZAR.Location = new System.Drawing.Point(6, 35);
            this.labelInputStartStep_ZAR.Name = "labelInputStartStep_ZAR";
            this.labelInputStartStep_ZAR.Size = new System.Drawing.Size(75, 15);
            this.labelInputStartStep_ZAR.TabIndex = 2;
            this.labelInputStartStep_ZAR.Text = "Старт шага:";
            // 
            // textBoxInputStopStep_ZAR
            // 
            this.textBoxInputStopStep_ZAR.Location = new System.Drawing.Point(134, 53);
            this.textBoxInputStopStep_ZAR.Name = "textBoxInputStopStep_ZAR";
            this.textBoxInputStopStep_ZAR.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputStopStep_ZAR.TabIndex = 1;
            // 
            // textBoxInputStartStep_ZAR
            // 
            this.textBoxInputStartStep_ZAR.Location = new System.Drawing.Point(6, 53);
            this.textBoxInputStartStep_ZAR.Name = "textBoxInputStartStep_ZAR";
            this.textBoxInputStartStep_ZAR.Size = new System.Drawing.Size(100, 22);
            this.textBoxInputStartStep_ZAR.TabIndex = 0;
            // 
            // buttonStartCode_ZAR
            // 
            this.buttonStartCode_ZAR.BackColor = System.Drawing.Color.Green;
            this.buttonStartCode_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartCode_ZAR.Location = new System.Drawing.Point(764, 23);
            this.buttonStartCode_ZAR.Name = "buttonStartCode_ZAR";
            this.buttonStartCode_ZAR.Size = new System.Drawing.Size(149, 62);
            this.buttonStartCode_ZAR.TabIndex = 7;
            this.buttonStartCode_ZAR.Text = "Выполнить";
            this.buttonStartCode_ZAR.UseVisualStyleBackColor = false;
            this.buttonStartCode_ZAR.Click += new System.EventHandler(this.buttonStartCode_ZAR_Click);
            // 
            // buttonSpravka_ZAR
            // 
            this.buttonSpravka_ZAR.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSpravka_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka_ZAR.Location = new System.Drawing.Point(1056, 23);
            this.buttonSpravka_ZAR.Name = "buttonSpravka_ZAR";
            this.buttonSpravka_ZAR.Size = new System.Drawing.Size(87, 62);
            this.buttonSpravka_ZAR.TabIndex = 8;
            this.buttonSpravka_ZAR.Text = "Справка";
            this.buttonSpravka_ZAR.UseVisualStyleBackColor = false;
            this.buttonSpravka_ZAR.Click += new System.EventHandler(this.buttonSpravka_ZAR_Click);
            // 
            // buttonSave_ZAR
            // 
            this.buttonSave_ZAR.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSave_ZAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave_ZAR.Location = new System.Drawing.Point(919, 23);
            this.buttonSave_ZAR.Name = "buttonSave_ZAR";
            this.buttonSave_ZAR.Size = new System.Drawing.Size(132, 62);
            this.buttonSave_ZAR.TabIndex = 9;
            this.buttonSave_ZAR.Text = "Сохранить";
            this.buttonSave_ZAR.UseVisualStyleBackColor = false;
            this.buttonSave_ZAR.Click += new System.EventHandler(this.buttonSave_ZAR_Click);
            // 
            // groupBoxOutputData_ZAR
            // 
            this.groupBoxOutputData_ZAR.Controls.Add(this.textBoxResult);
            this.groupBoxOutputData_ZAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_ZAR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_ZAR.Name = "groupBoxOutputData_ZAR";
            this.groupBoxOutputData_ZAR.Size = new System.Drawing.Size(200, 496);
            this.groupBoxOutputData_ZAR.TabIndex = 0;
            this.groupBoxOutputData_ZAR.TabStop = false;
            this.groupBoxOutputData_ZAR.Text = "Вывод:";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.Location = new System.Drawing.Point(3, 16);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(194, 477);
            this.textBoxResult.TabIndex = 2;
            this.textBoxResult.TabStop = false;
            // 
            // chart_ZAR
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_ZAR.ChartAreas.Add(chartArea3);
            this.chart_ZAR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chart_ZAR.Legends.Add(legend3);
            this.chart_ZAR.Location = new System.Drawing.Point(0, 0);
            this.chart_ZAR.Name = "chart_ZAR";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart_ZAR.Series.Add(series3);
            this.chart_ZAR.Size = new System.Drawing.Size(954, 496);
            this.chart_ZAR.TabIndex = 0;
            this.chart_ZAR.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            title3.ForeColor = System.Drawing.Color.Blue;
            title3.Name = "Title1";
            title3.Text = "График функции";
            this.chart_ZAR.Titles.Add(title3);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 596);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelF);
            this.Controls.Add(this.panelStatistic);
            this.Controls.Add(this.panel);
            this.MinimumSize = new System.Drawing.Size(1162, 591);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 4 | Вариант 9 | Заиров Артур Ранисович";
            this.panel.ResumeLayout(false);
            this.groupBoxTask_ZAR.ResumeLayout(false);
            this.groupBoxTask_ZAR.PerformLayout();
            this.panelStatistic.ResumeLayout(false);
            this.panelF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxInputData_ZAR.ResumeLayout(false);
            this.groupBoxInputData_ZAR.PerformLayout();
            this.groupBoxOutputData_ZAR.ResumeLayout(false);
            this.groupBoxOutputData_ZAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ZAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.Panel panelF;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxTask_ZAR;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxInputData_ZAR;
        private System.Windows.Forms.Label labelInputStopStep_ZAR;
        private System.Windows.Forms.Label labelInputStartStep_ZAR;
        private System.Windows.Forms.TextBox textBoxInputStopStep_ZAR;
        private System.Windows.Forms.TextBox textBoxInputStartStep_ZAR;
        private System.Windows.Forms.Button buttonStartCode_ZAR;
        private System.Windows.Forms.Button buttonSpravka_ZAR;
        private System.Windows.Forms.Button buttonSave_ZAR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZAR;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ZAR;
    }
}

