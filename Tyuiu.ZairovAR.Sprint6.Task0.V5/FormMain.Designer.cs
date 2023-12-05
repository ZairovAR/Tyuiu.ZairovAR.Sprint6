namespace Tyuiu.ZairovAR.Sprint6.Task0.V5
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
            this.groupBoxUslovie_ZAR = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula = new System.Windows.Forms.PictureBox();
            this.groupBoxInputData_ZAR = new System.Windows.Forms.GroupBox();
            this.textBoxInputX_ZAR = new System.Windows.Forms.TextBox();
            this.label1_ZAR = new System.Windows.Forms.Label();
            this.groupBoxOutputData_ZAR = new System.Windows.Forms.GroupBox();
            this.labelResult_ZAR = new System.Windows.Forms.Label();
            this.textBoxResult_ZAR = new System.Windows.Forms.TextBox();
            this.buttonQuestion_ZAR = new System.Windows.Forms.Button();
            this.buttonVipolnit_ZAR = new System.Windows.Forms.Button();
            this.groupBoxUslovie_ZAR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).BeginInit();
            this.groupBoxInputData_ZAR.SuspendLayout();
            this.groupBoxOutputData_ZAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUslovie_ZAR
            // 
            this.groupBoxUslovie_ZAR.Controls.Add(this.textBox1);
            this.groupBoxUslovie_ZAR.Controls.Add(this.pictureBoxFormula);
            this.groupBoxUslovie_ZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxUslovie_ZAR.Location = new System.Drawing.Point(12, 25);
            this.groupBoxUslovie_ZAR.Name = "groupBoxUslovie_ZAR";
            this.groupBoxUslovie_ZAR.Size = new System.Drawing.Size(763, 210);
            this.groupBoxUslovie_ZAR.TabIndex = 0;
            this.groupBoxUslovie_ZAR.TabStop = false;
            this.groupBoxUslovie_ZAR.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(437, 176);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = " Вычислить выражение по формуле";
            // 
            // pictureBoxFormula
            // 
            this.pictureBoxFormula.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFormula.Image")));
            this.pictureBoxFormula.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBoxFormula.Location = new System.Drawing.Point(449, 19);
            this.pictureBoxFormula.Name = "pictureBoxFormula";
            this.pictureBoxFormula.Size = new System.Drawing.Size(308, 50);
            this.pictureBoxFormula.TabIndex = 2;
            this.pictureBoxFormula.TabStop = false;
            // 
            // groupBoxInputData_ZAR
            // 
            this.groupBoxInputData_ZAR.Controls.Add(this.textBoxInputX_ZAR);
            this.groupBoxInputData_ZAR.Controls.Add(this.label1_ZAR);
            this.groupBoxInputData_ZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInputData_ZAR.Location = new System.Drawing.Point(12, 241);
            this.groupBoxInputData_ZAR.Name = "groupBoxInputData_ZAR";
            this.groupBoxInputData_ZAR.Size = new System.Drawing.Size(443, 160);
            this.groupBoxInputData_ZAR.TabIndex = 1;
            this.groupBoxInputData_ZAR.TabStop = false;
            this.groupBoxInputData_ZAR.Text = "Ввод данных";
            // 
            // textBoxInputX_ZAR
            // 
            this.textBoxInputX_ZAR.Location = new System.Drawing.Point(10, 101);
            this.textBoxInputX_ZAR.Name = "textBoxInputX_ZAR";
            this.textBoxInputX_ZAR.Size = new System.Drawing.Size(132, 26);
            this.textBoxInputX_ZAR.TabIndex = 1;
            this.textBoxInputX_ZAR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxInputX_ZAR_KeyPress);
            // 
            // label1_ZAR
            // 
            this.label1_ZAR.AutoSize = true;
            this.label1_ZAR.Location = new System.Drawing.Point(6, 78);
            this.label1_ZAR.Name = "label1_ZAR";
            this.label1_ZAR.Size = new System.Drawing.Size(123, 20);
            this.label1_ZAR.TabIndex = 0;
            this.label1_ZAR.Text = "Переменная X:";
            // 
            // groupBoxOutputData_ZAR
            // 
            this.groupBoxOutputData_ZAR.Controls.Add(this.labelResult_ZAR);
            this.groupBoxOutputData_ZAR.Controls.Add(this.textBoxResult_ZAR);
            this.groupBoxOutputData_ZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutputData_ZAR.Location = new System.Drawing.Point(482, 241);
            this.groupBoxOutputData_ZAR.Name = "groupBoxOutputData_ZAR";
            this.groupBoxOutputData_ZAR.Size = new System.Drawing.Size(293, 160);
            this.groupBoxOutputData_ZAR.TabIndex = 2;
            this.groupBoxOutputData_ZAR.TabStop = false;
            this.groupBoxOutputData_ZAR.Text = "Вывод данных";
            // 
            // labelResult_ZAR
            // 
            this.labelResult_ZAR.AutoSize = true;
            this.labelResult_ZAR.Location = new System.Drawing.Point(6, 78);
            this.labelResult_ZAR.Name = "labelResult_ZAR";
            this.labelResult_ZAR.Size = new System.Drawing.Size(93, 20);
            this.labelResult_ZAR.TabIndex = 1;
            this.labelResult_ZAR.Text = "Результат:";
            // 
            // textBoxResult_ZAR
            // 
            this.textBoxResult_ZAR.Location = new System.Drawing.Point(10, 101);
            this.textBoxResult_ZAR.Name = "textBoxResult_ZAR";
            this.textBoxResult_ZAR.ReadOnly = true;
            this.textBoxResult_ZAR.Size = new System.Drawing.Size(272, 26);
            this.textBoxResult_ZAR.TabIndex = 0;
            // 
            // buttonQuestion_ZAR
            // 
            this.buttonQuestion_ZAR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonQuestion_ZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonQuestion_ZAR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonQuestion_ZAR.Location = new System.Drawing.Point(623, 407);
            this.buttonQuestion_ZAR.Name = "buttonQuestion_ZAR";
            this.buttonQuestion_ZAR.Size = new System.Drawing.Size(38, 31);
            this.buttonQuestion_ZAR.TabIndex = 5;
            this.buttonQuestion_ZAR.Text = "?";
            this.buttonQuestion_ZAR.UseVisualStyleBackColor = true;
            this.buttonQuestion_ZAR.Click += new System.EventHandler(this.buttonQuestion_ZAR_Click);
            // 
            // buttonVipolnit_ZAR
            // 
            this.buttonVipolnit_ZAR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonVipolnit_ZAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonVipolnit_ZAR.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonVipolnit_ZAR.Location = new System.Drawing.Point(667, 407);
            this.buttonVipolnit_ZAR.Name = "buttonVipolnit_ZAR";
            this.buttonVipolnit_ZAR.Size = new System.Drawing.Size(108, 31);
            this.buttonVipolnit_ZAR.TabIndex = 6;
            this.buttonVipolnit_ZAR.Text = "Выполнить";
            this.buttonVipolnit_ZAR.UseVisualStyleBackColor = true;
            this.buttonVipolnit_ZAR.Click += new System.EventHandler(this.buttonVipolnit_ZAR_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVipolnit_ZAR);
            this.Controls.Add(this.buttonQuestion_ZAR);
            this.Controls.Add(this.groupBoxOutputData_ZAR);
            this.Controls.Add(this.groupBoxInputData_ZAR);
            this.Controls.Add(this.groupBoxUslovie_ZAR);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 0 | Вариант 5 | Заиров А.Р.";
            this.groupBoxUslovie_ZAR.ResumeLayout(false);
            this.groupBoxUslovie_ZAR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula)).EndInit();
            this.groupBoxInputData_ZAR.ResumeLayout(false);
            this.groupBoxInputData_ZAR.PerformLayout();
            this.groupBoxOutputData_ZAR.ResumeLayout(false);
            this.groupBoxOutputData_ZAR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUslovie_ZAR;
        private System.Windows.Forms.PictureBox pictureBoxFormula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBoxInputData_ZAR;
        private System.Windows.Forms.Label label1_ZAR;
        private System.Windows.Forms.TextBox textBoxInputX_ZAR;
        private System.Windows.Forms.GroupBox groupBoxOutputData_ZAR;
        private System.Windows.Forms.Label labelResult_ZAR;
        private System.Windows.Forms.TextBox textBoxResult_ZAR;
        private System.Windows.Forms.Button buttonQuestion_ZAR;
        private System.Windows.Forms.Button buttonVipolnit_ZAR;
    }
}

