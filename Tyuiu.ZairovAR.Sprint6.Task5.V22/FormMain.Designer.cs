namespace Tyuiu.ZairovAR.Sprint6.Task5.V22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonSpravka_ZAR = new System.Windows.Forms.Button();
            this.buttonSave_ZAR = new System.Windows.Forms.Button();
            this.buttonStartCode_ZAR = new System.Windows.Forms.Button();
            this.groupBoxTask_ZAR = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.groupBoxOutputData_ZAR = new System.Windows.Forms.GroupBox();
            this.dataGridViewXOX = new System.Windows.Forms.DataGridView();
            this.panelF = new System.Windows.Forms.Panel();
            this.chart_ZAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel.SuspendLayout();
            this.groupBoxTask_ZAR.SuspendLayout();
            this.panelStatistic.SuspendLayout();
            this.groupBoxOutputData_ZAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXOX)).BeginInit();
            this.panelF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_ZAR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Menu;
            this.panel.Controls.Add(this.buttonSpravka_ZAR);
            this.panel.Controls.Add(this.buttonSave_ZAR);
            this.panel.Controls.Add(this.buttonStartCode_ZAR);
            this.panel.Controls.Add(this.groupBoxTask_ZAR);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(875, 100);
            this.panel.TabIndex = 1;
            // 
            // buttonSpravka_ZAR
            // 
            this.buttonSpravka_ZAR.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSpravka_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka_ZAR.Location = new System.Drawing.Point(777, 20);
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
            this.buttonSave_ZAR.Location = new System.Drawing.Point(664, 20);
            this.buttonSave_ZAR.Name = "buttonSave_ZAR";
            this.buttonSave_ZAR.Size = new System.Drawing.Size(107, 62);
            this.buttonSave_ZAR.TabIndex = 9;
            this.buttonSave_ZAR.Text = "Открыть файл";
            this.buttonSave_ZAR.UseVisualStyleBackColor = false;
            this.buttonSave_ZAR.Click += new System.EventHandler(this.buttonSave_ZAR_Click);
            // 
            // buttonStartCode_ZAR
            // 
            this.buttonStartCode_ZAR.BackColor = System.Drawing.Color.Green;
            this.buttonStartCode_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartCode_ZAR.Location = new System.Drawing.Point(530, 20);
            this.buttonStartCode_ZAR.Name = "buttonStartCode_ZAR";
            this.buttonStartCode_ZAR.Size = new System.Drawing.Size(128, 62);
            this.buttonStartCode_ZAR.TabIndex = 7;
            this.buttonStartCode_ZAR.Text = "Выполнить";
            this.buttonStartCode_ZAR.UseVisualStyleBackColor = false;
            this.buttonStartCode_ZAR.Click += new System.EventHandler(this.buttonStartCode_ZAR_Click);
            // 
            // groupBoxTask_ZAR
            // 
            this.groupBoxTask_ZAR.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_ZAR.Location = new System.Drawing.Point(3, 3);
            this.groupBoxTask_ZAR.Name = "groupBoxTask_ZAR";
            this.groupBoxTask_ZAR.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_ZAR.Size = new System.Drawing.Size(521, 91);
            this.groupBoxTask_ZAR.TabIndex = 3;
            this.groupBoxTask_ZAR.TabStop = false;
            this.groupBoxTask_ZAR.Text = "Условие";
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Location = new System.Drawing.Point(9, 18);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(503, 61);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = resources.GetString("textBoxUslovie.Text");
            // 
            // panelStatistic
            // 
            this.panelStatistic.BackColor = System.Drawing.SystemColors.Menu;
            this.panelStatistic.Controls.Add(this.groupBoxOutputData_ZAR);
            this.panelStatistic.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatistic.Location = new System.Drawing.Point(0, 100);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(200, 363);
            this.panelStatistic.TabIndex = 2;
            // 
            // groupBoxOutputData_ZAR
            // 
            this.groupBoxOutputData_ZAR.Controls.Add(this.dataGridViewXOX);
            this.groupBoxOutputData_ZAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutputData_ZAR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutputData_ZAR.Name = "groupBoxOutputData_ZAR";
            this.groupBoxOutputData_ZAR.Size = new System.Drawing.Size(200, 363);
            this.groupBoxOutputData_ZAR.TabIndex = 0;
            this.groupBoxOutputData_ZAR.TabStop = false;
            this.groupBoxOutputData_ZAR.Text = "Вывод:";
            // 
            // dataGridViewXOX
            // 
            this.dataGridViewXOX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXOX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewXOX.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewXOX.Name = "dataGridViewXOX";
            this.dataGridViewXOX.Size = new System.Drawing.Size(194, 344);
            this.dataGridViewXOX.TabIndex = 0;
            // 
            // panelF
            // 
            this.panelF.BackColor = System.Drawing.SystemColors.Menu;
            this.panelF.Controls.Add(this.chart_ZAR);
            this.panelF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelF.Location = new System.Drawing.Point(200, 100);
            this.panelF.Name = "panelF";
            this.panelF.Size = new System.Drawing.Size(675, 363);
            this.panelF.TabIndex = 3;
            // 
            // chart_ZAR
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_ZAR.ChartAreas.Add(chartArea1);
            this.chart_ZAR.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart_ZAR.Legends.Add(legend1);
            this.chart_ZAR.Location = new System.Drawing.Point(0, 0);
            this.chart_ZAR.Name = "chart_ZAR";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_ZAR.Series.Add(series1);
            this.chart_ZAR.Size = new System.Drawing.Size(675, 363);
            this.chart_ZAR.TabIndex = 0;
            this.chart_ZAR.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 463);
            this.Controls.Add(this.panelF);
            this.Controls.Add(this.panelStatistic);
            this.Controls.Add(this.panel);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 9 | Заиров Артур Ранисович";
            this.panel.ResumeLayout(false);
            this.groupBoxTask_ZAR.ResumeLayout(false);
            this.groupBoxTask_ZAR.PerformLayout();
            this.panelStatistic.ResumeLayout(false);
            this.groupBoxOutputData_ZAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXOX)).EndInit();
            this.panelF.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_ZAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button buttonSpravka_ZAR;
        private System.Windows.Forms.Button buttonSave_ZAR;
        private System.Windows.Forms.Button buttonStartCode_ZAR;
        private System.Windows.Forms.GroupBox groupBoxTask_ZAR;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZAR;
        private System.Windows.Forms.Panel panelF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_ZAR;
        private System.Windows.Forms.DataGridView dataGridViewXOX;
    }
}

