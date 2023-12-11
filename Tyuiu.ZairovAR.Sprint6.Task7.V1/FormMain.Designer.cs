namespace Tyuiu.ZairovAR.Sprint6.Task7.V1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonFileExpress = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxTask_ZAR = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxInput = new System.Windows.Forms.GroupBox();
            this.dataGridViewInput = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutput = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTipButten = new System.Windows.Forms.ToolTip(this.components);
            this.saveFileDialogMatrix = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxTask_ZAR.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonFile);
            this.panel1.Controls.Add(this.buttonFileExpress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 61);
            this.panel1.TabIndex = 1;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp.Image = global::Tyuiu.ZairovAR.Sprint6.Task7.V1.Properties.Resources.help;
            this.buttonHelp.Location = new System.Drawing.Point(985, 0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 61);
            this.buttonHelp.TabIndex = 0;
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::Tyuiu.ZairovAR.Sprint6.Task7.V1.Properties.Resources.page_save;
            this.buttonSave.Location = new System.Drawing.Point(165, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 55);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Image = global::Tyuiu.ZairovAR.Sprint6.Task7.V1.Properties.Resources.folder_go;
            this.buttonFile.Location = new System.Drawing.Point(84, 3);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 55);
            this.buttonFile.TabIndex = 0;
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonFileExpress
            // 
            this.buttonFileExpress.Image = global::Tyuiu.ZairovAR.Sprint6.Task7.V1.Properties.Resources.folder;
            this.buttonFileExpress.Location = new System.Drawing.Point(3, 3);
            this.buttonFileExpress.Name = "buttonFileExpress";
            this.buttonFileExpress.Size = new System.Drawing.Size(75, 55);
            this.buttonFileExpress.TabIndex = 0;
            this.buttonFileExpress.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxTask_ZAR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 65);
            this.panel3.TabIndex = 3;
            // 
            // groupBoxTask_ZAR
            // 
            this.groupBoxTask_ZAR.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_ZAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_ZAR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_ZAR.Name = "groupBoxTask_ZAR";
            this.groupBoxTask_ZAR.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_ZAR.Size = new System.Drawing.Size(1060, 65);
            this.groupBoxTask_ZAR.TabIndex = 4;
            this.groupBoxTask_ZAR.TabStop = false;
            this.groupBoxTask_ZAR.Text = "Условие";
            // 
            // textBoxUslovie
            // 
            this.textBoxUslovie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUslovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxUslovie.Location = new System.Drawing.Point(5, 20);
            this.textBoxUslovie.Multiline = true;
            this.textBoxUslovie.Name = "textBoxUslovie";
            this.textBoxUslovie.ReadOnly = true;
            this.textBoxUslovie.Size = new System.Drawing.Size(1050, 40);
            this.textBoxUslovie.TabIndex = 1;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = resources.GetString("textBoxUslovie.Text");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxInput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 451);
            this.panel2.TabIndex = 4;
            // 
            // groupBoxInput
            // 
            this.groupBoxInput.Controls.Add(this.dataGridViewInput);
            this.groupBoxInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput.Name = "groupBoxInput";
            this.groupBoxInput.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxInput.Size = new System.Drawing.Size(361, 451);
            this.groupBoxInput.TabIndex = 1;
            this.groupBoxInput.TabStop = false;
            this.groupBoxInput.Text = "Ввод";
            // 
            // dataGridViewInput
            // 
            this.dataGridViewInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput.ColumnHeadersVisible = false;
            this.dataGridViewInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInput.Location = new System.Drawing.Point(10, 23);
            this.dataGridViewInput.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewInput.Name = "dataGridViewInput";
            this.dataGridViewInput.RowHeadersVisible = false;
            this.dataGridViewInput.Size = new System.Drawing.Size(341, 418);
            this.dataGridViewInput.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOutput);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(361, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(699, 451);
            this.panel4.TabIndex = 5;
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.dataGridViewOutput);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(1, 10, 10, 10);
            this.groupBoxOutput.Size = new System.Drawing.Size(699, 451);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Вывод";
            // 
            // dataGridViewOutput
            // 
            this.dataGridViewOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutput.ColumnHeadersVisible = false;
            this.dataGridViewOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOutput.Location = new System.Drawing.Point(1, 23);
            this.dataGridViewOutput.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewOutput.Name = "dataGridViewOutput";
            this.dataGridViewOutput.RowHeadersVisible = false;
            this.dataGridViewOutput.Size = new System.Drawing.Size(688, 418);
            this.dataGridViewOutput.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 577);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 1 | Заиров Артур Ранисович";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxTask_ZAR.ResumeLayout(false);
            this.groupBoxTask_ZAR.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBoxInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput)).EndInit();
            this.panel4.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonFileExpress;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxTask_ZAR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxInput;
        private System.Windows.Forms.DataGridView dataGridViewInput;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.DataGridView dataGridViewOutput;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTipButten;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix;
    }
}

