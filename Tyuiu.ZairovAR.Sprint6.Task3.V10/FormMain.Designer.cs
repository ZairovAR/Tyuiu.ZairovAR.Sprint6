namespace Tyuiu.ZairovAR.Sprint6.Task3.V10
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
            this.groupBoxTask_ZAR = new System.Windows.Forms.GroupBox();
            this.dataGridViewInputMatrix_ZAR = new System.Windows.Forms.DataGridView();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.groupBoxOutputData_ZAR = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewOutputMatrix_ZAR = new System.Windows.Forms.DataGridView();
            this.buttonSpravka_ZAR = new System.Windows.Forms.Button();
            this.buttonStartCode_ZAR = new System.Windows.Forms.Button();
            this.groupBoxTask_ZAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix_ZAR)).BeginInit();
            this.groupBoxOutputData_ZAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputMatrix_ZAR)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_ZAR
            // 
            this.groupBoxTask_ZAR.Controls.Add(this.dataGridViewInputMatrix_ZAR);
            this.groupBoxTask_ZAR.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_ZAR.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_ZAR.Name = "groupBoxTask_ZAR";
            this.groupBoxTask_ZAR.Size = new System.Drawing.Size(449, 391);
            this.groupBoxTask_ZAR.TabIndex = 3;
            this.groupBoxTask_ZAR.TabStop = false;
            this.groupBoxTask_ZAR.Text = "Условие";
            // 
            // dataGridViewInputMatrix_ZAR
            // 
            this.dataGridViewInputMatrix_ZAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInputMatrix_ZAR.ColumnHeadersVisible = false;
            this.dataGridViewInputMatrix_ZAR.Location = new System.Drawing.Point(6, 57);
            this.dataGridViewInputMatrix_ZAR.Name = "dataGridViewInputMatrix_ZAR";
            this.dataGridViewInputMatrix_ZAR.ReadOnly = true;
            this.dataGridViewInputMatrix_ZAR.RowHeadersVisible = false;
            this.dataGridViewInputMatrix_ZAR.Size = new System.Drawing.Size(254, 209);
            this.dataGridViewInputMatrix_ZAR.TabIndex = 1;
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Location = new System.Drawing.Point(6, 21);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(437, 63);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.";
            // 
            // groupBoxOutputData_ZAR
            // 
            this.groupBoxOutputData_ZAR.Controls.Add(this.label1);
            this.groupBoxOutputData_ZAR.Controls.Add(this.dataGridViewOutputMatrix_ZAR);
            this.groupBoxOutputData_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_ZAR.Location = new System.Drawing.Point(467, 13);
            this.groupBoxOutputData_ZAR.Name = "groupBoxOutputData_ZAR";
            this.groupBoxOutputData_ZAR.Size = new System.Drawing.Size(480, 390);
            this.groupBoxOutputData_ZAR.TabIndex = 8;
            this.groupBoxOutputData_ZAR.TabStop = false;
            this.groupBoxOutputData_ZAR.Text = "Вывод данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Результат:";
            // 
            // dataGridViewOutputMatrix_ZAR
            // 
            this.dataGridViewOutputMatrix_ZAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutputMatrix_ZAR.ColumnHeadersVisible = false;
            this.dataGridViewOutputMatrix_ZAR.Location = new System.Drawing.Point(6, 56);
            this.dataGridViewOutputMatrix_ZAR.Name = "dataGridViewOutputMatrix_ZAR";
            this.dataGridViewOutputMatrix_ZAR.ReadOnly = true;
            this.dataGridViewOutputMatrix_ZAR.RowHeadersVisible = false;
            this.dataGridViewOutputMatrix_ZAR.Size = new System.Drawing.Size(254, 209);
            this.dataGridViewOutputMatrix_ZAR.TabIndex = 1;
            // 
            // buttonSpravka_ZAR
            // 
            this.buttonSpravka_ZAR.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonSpravka_ZAR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonSpravka_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpravka_ZAR.Location = new System.Drawing.Point(803, 409);
            this.buttonSpravka_ZAR.Name = "buttonSpravka_ZAR";
            this.buttonSpravka_ZAR.Size = new System.Drawing.Size(37, 38);
            this.buttonSpravka_ZAR.TabIndex = 10;
            this.buttonSpravka_ZAR.Text = "?";
            this.buttonSpravka_ZAR.UseVisualStyleBackColor = false;
            this.buttonSpravka_ZAR.Click += new System.EventHandler(this.buttonSpravka_ZAR_Click);
            // 
            // buttonStartCode_ZAR
            // 
            this.buttonStartCode_ZAR.BackColor = System.Drawing.Color.Green;
            this.buttonStartCode_ZAR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonStartCode_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartCode_ZAR.Location = new System.Drawing.Point(846, 409);
            this.buttonStartCode_ZAR.Name = "buttonStartCode_ZAR";
            this.buttonStartCode_ZAR.Size = new System.Drawing.Size(101, 38);
            this.buttonStartCode_ZAR.TabIndex = 11;
            this.buttonStartCode_ZAR.Text = "Выполнить";
            this.buttonStartCode_ZAR.UseVisualStyleBackColor = false;
            this.buttonStartCode_ZAR.Click += new System.EventHandler(this.buttonStartCode_ZAR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 450);
            this.Controls.Add(this.buttonStartCode_ZAR);
            this.Controls.Add(this.buttonSpravka_ZAR);
            this.Controls.Add(this.groupBoxOutputData_ZAR);
            this.Controls.Add(this.groupBoxTask_ZAR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 3 | Вариант 10 | Заиров Артур Ранисович";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_ZAR.ResumeLayout(false);
            this.groupBoxTask_ZAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInputMatrix_ZAR)).EndInit();
            this.groupBoxOutputData_ZAR.ResumeLayout(false);
            this.groupBoxOutputData_ZAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutputMatrix_ZAR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_ZAR;
        private System.Windows.Forms.DataGridView dataGridViewInputMatrix_ZAR;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewOutputMatrix_ZAR;
        private System.Windows.Forms.Button buttonSpravka_ZAR;
        private System.Windows.Forms.Button buttonStartCode_ZAR;
    }
}

