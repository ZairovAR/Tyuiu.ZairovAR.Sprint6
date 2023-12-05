namespace Tyuiu.ZairovAR.Sprint6.Task2.V12
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_ZAR = new System.Windows.Forms.GroupBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.groupBoxInputData_ZAR = new System.Windows.Forms.GroupBox();
            this.labelInputStopStep_ZAR = new System.Windows.Forms.Label();
            this.labelInputStartStep_ZAR = new System.Windows.Forms.Label();
            this.textBoxInputStopStep_ZAR = new System.Windows.Forms.TextBox();
            this.textBoxInputStartStep_ZAR = new System.Windows.Forms.TextBox();
            this.buttonSpravka_ZAR = new System.Windows.Forms.Button();
            this.buttonStartCode_ZAR = new System.Windows.Forms.Button();
            this.groupBoxOutputData_ZAR = new System.Windows.Forms.GroupBox();
            this.dataGridViewFunction_ZAR = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_ZAR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_ZAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxInputData_ZAR.SuspendLayout();
            this.groupBoxOutputData_ZAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZAR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZAR
            // 
            this.groupBoxTask_ZAR.Controls.Add(this.pictureBoxFormula);
            this.groupBoxTask_ZAR.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_ZAR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ZAR.Name = "groupBoxTask_ZAR";
            this.groupBoxTask_ZAR.Size = new System.Drawing.Size(509, 338);
            this.groupBoxTask_ZAR.TabIndex = 2;
            this.groupBoxTask_ZAR.TabStop = false;
            this.groupBoxTask_ZAR.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.Location = new System.Drawing.Point(9, 40);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(191, 46);
            this.pictureBoxFormula.TabIndex = 1;
            this.pictureBoxFormula.TabStop = false;
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(497, 282);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = "Протабулироавать функцию:\r\n\r\n\r\n\r\n\r\nна заданном диапазоне. Результат вывести в Dat" +
    "aGridView и построить график функции.";
            // 
            // groupBoxInputData_ZAR
            // 
            this.groupBoxInputData_ZAR.Controls.Add(this.labelInputStopStep_ZAR);
            this.groupBoxInputData_ZAR.Controls.Add(this.labelInputStartStep_ZAR);
            this.groupBoxInputData_ZAR.Controls.Add(this.textBoxInputStopStep_ZAR);
            this.groupBoxInputData_ZAR.Controls.Add(this.textBoxInputStartStep_ZAR);
            this.groupBoxInputData_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_ZAR.Location = new System.Drawing.Point(12, 357);
            this.groupBoxInputData_ZAR.Name = "groupBoxInputData_ZAR";
            this.groupBoxInputData_ZAR.Size = new System.Drawing.Size(240, 81);
            this.groupBoxInputData_ZAR.TabIndex = 4;
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
            // buttonSpravka_ZAR
            // 
            this.buttonSpravka_ZAR.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSpravka_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka_ZAR.Location = new System.Drawing.Point(279, 368);
            this.buttonSpravka_ZAR.Name = "buttonSpravka_ZAR";
            this.buttonSpravka_ZAR.Size = new System.Drawing.Size(87, 62);
            this.buttonSpravka_ZAR.TabIndex = 5;
            this.buttonSpravka_ZAR.Text = "Справка";
            this.buttonSpravka_ZAR.UseVisualStyleBackColor = false;
            this.buttonSpravka_ZAR.Click += new System.EventHandler(this.buttonSpravka_ZAR_Click);
            // 
            // buttonStartCode_ZAR
            // 
            this.buttonStartCode_ZAR.BackColor = System.Drawing.Color.Green;
            this.buttonStartCode_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartCode_ZAR.Location = new System.Drawing.Point(372, 370);
            this.buttonStartCode_ZAR.Name = "buttonStartCode_ZAR";
            this.buttonStartCode_ZAR.Size = new System.Drawing.Size(149, 62);
            this.buttonStartCode_ZAR.TabIndex = 6;
            this.buttonStartCode_ZAR.Text = "Выполнить";
            this.buttonStartCode_ZAR.UseVisualStyleBackColor = false;
            this.buttonStartCode_ZAR.Click += new System.EventHandler(this.buttonStartCode_ZAR_Click);
            this.buttonStartCode_ZAR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonStartCode_ZAR_MouseDown);
            this.buttonStartCode_ZAR.MouseEnter += new System.EventHandler(this.buttonStartCode_ZAR_MouseEnter);
            this.buttonStartCode_ZAR.MouseLeave += new System.EventHandler(this.buttonStartCode_ZAR_MouseLeave);
            // 
            // groupBoxOutputData_ZAR
            // 
            this.groupBoxOutputData_ZAR.Controls.Add(this.chartFunction_ZAR);
            this.groupBoxOutputData_ZAR.Controls.Add(this.dataGridViewFunction_ZAR);
            this.groupBoxOutputData_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_ZAR.Location = new System.Drawing.Point(527, 13);
            this.groupBoxOutputData_ZAR.Name = "groupBoxOutputData_ZAR";
            this.groupBoxOutputData_ZAR.Size = new System.Drawing.Size(718, 425);
            this.groupBoxOutputData_ZAR.TabIndex = 7;
            this.groupBoxOutputData_ZAR.TabStop = false;
            this.groupBoxOutputData_ZAR.Text = "Вывод данных";
            // 
            // dataGridViewFunction_ZAR
            // 
            this.dataGridViewFunction_ZAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_ZAR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_ZAR.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewFunction_ZAR.Name = "dataGridViewFunction_ZAR";
            this.dataGridViewFunction_ZAR.RowHeadersVisible = false;
            this.dataGridViewFunction_ZAR.Size = new System.Drawing.Size(156, 397);
            this.dataGridViewFunction_ZAR.TabIndex = 0;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 75;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 75;
            // 
            // chartFunction_ZAR
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFunction_ZAR.ChartAreas.Add(chartArea4);
            this.chartFunction_ZAR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend4.Name = "Legend1";
            this.chartFunction_ZAR.Legends.Add(legend4);
            this.chartFunction_ZAR.Location = new System.Drawing.Point(168, 20);
            this.chartFunction_ZAR.Name = "chartFunction_ZAR";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.IsVisibleInLegend = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFunction_ZAR.Series.Add(series4);
            this.chartFunction_ZAR.Size = new System.Drawing.Size(544, 399);
            this.chartFunction_ZAR.TabIndex = 1;
            this.chartFunction_ZAR.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 450);
            this.Controls.Add(this.groupBoxOutputData_ZAR);
            this.Controls.Add(this.buttonStartCode_ZAR);
            this.Controls.Add(this.buttonSpravka_ZAR);
            this.Controls.Add(this.groupBoxInputData_ZAR);
            this.Controls.Add(this.groupBoxTask_ZAR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 2 | Вариант 12 | Заиров Артур Ранисович";
            this.groupBoxTask_ZAR.ResumeLayout(false);
            this.groupBoxTask_ZAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxInputData_ZAR.ResumeLayout(false);
            this.groupBoxInputData_ZAR.PerformLayout();
            this.groupBoxOutputData_ZAR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_ZAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_ZAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZAR;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.GroupBox groupBoxInputData_ZAR;
        private System.Windows.Forms.Label labelInputStopStep_ZAR;
        private System.Windows.Forms.Label labelInputStartStep_ZAR;
        private System.Windows.Forms.TextBox textBoxInputStopStep_ZAR;
        private System.Windows.Forms.TextBox textBoxInputStartStep_ZAR;
        private System.Windows.Forms.Button buttonSpravka_ZAR;
        private System.Windows.Forms.Button buttonStartCode_ZAR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZAR;
        private System.Windows.Forms.DataGridView dataGridViewFunction_ZAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_ZAR;
    }
}

