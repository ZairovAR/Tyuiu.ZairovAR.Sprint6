namespace Tyuiu.ZairovAR.Sprint6.Task6.V8
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxInput_ZAR = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxTask_ZAR = new System.Windows.Forms.GroupBox();
            this.textBoxUslovie = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxOutput_ZAR = new System.Windows.Forms.GroupBox();
            this.textBoxOut = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.textBoxInputData = new System.Windows.Forms.TextBox();
            this.buttonFileExpress = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.openFileDialogTask = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxInput_ZAR.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxTask_ZAR.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxOutput_ZAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonHelp);
            this.panel1.Controls.Add(this.buttonFile);
            this.panel1.Controls.Add(this.buttonFileExpress);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 61);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBoxInput_ZAR);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 382);
            this.panel2.TabIndex = 1;
            // 
            // groupBoxInput_ZAR
            // 
            this.groupBoxInput_ZAR.Controls.Add(this.textBoxInputData);
            this.groupBoxInput_ZAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_ZAR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_ZAR.Name = "groupBoxInput_ZAR";
            this.groupBoxInput_ZAR.Size = new System.Drawing.Size(361, 382);
            this.groupBoxInput_ZAR.TabIndex = 0;
            this.groupBoxInput_ZAR.TabStop = false;
            this.groupBoxInput_ZAR.Text = "Ввод:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBoxTask_ZAR);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(787, 65);
            this.panel3.TabIndex = 2;
            // 
            // groupBoxTask_ZAR
            // 
            this.groupBoxTask_ZAR.Controls.Add(this.textBoxUslovie);
            this.groupBoxTask_ZAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_ZAR.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxTask_ZAR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTask_ZAR.Name = "groupBoxTask_ZAR";
            this.groupBoxTask_ZAR.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxTask_ZAR.Size = new System.Drawing.Size(787, 65);
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
            this.textBoxUslovie.Size = new System.Drawing.Size(777, 40);
            this.textBoxUslovie.TabIndex = 0;
            this.textBoxUslovie.TabStop = false;
            this.textBoxUslovie.Text = resources.GetString("textBoxUslovie.Text");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBoxOutput_ZAR);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(361, 126);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(426, 382);
            this.panel4.TabIndex = 3;
            // 
            // groupBoxOutput_ZAR
            // 
            this.groupBoxOutput_ZAR.Controls.Add(this.textBoxOut);
            this.groupBoxOutput_ZAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutput_ZAR.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutput_ZAR.Name = "groupBoxOutput_ZAR";
            this.groupBoxOutput_ZAR.Size = new System.Drawing.Size(426, 382);
            this.groupBoxOutput_ZAR.TabIndex = 0;
            this.groupBoxOutput_ZAR.TabStop = false;
            this.groupBoxOutput_ZAR.Text = "Вывод:";
            // 
            // textBoxOut
            // 
            this.textBoxOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxOut.Location = new System.Drawing.Point(3, 16);
            this.textBoxOut.Multiline = true;
            this.textBoxOut.Name = "textBoxOut";
            this.textBoxOut.Size = new System.Drawing.Size(420, 363);
            this.textBoxOut.TabIndex = 1;
            this.textBoxOut.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(361, 126);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 382);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // textBoxInputData
            // 
            this.textBoxInputData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxInputData.Location = new System.Drawing.Point(3, 16);
            this.textBoxInputData.Multiline = true;
            this.textBoxInputData.Name = "textBoxInputData";
            this.textBoxInputData.Size = new System.Drawing.Size(355, 363);
            this.textBoxInputData.TabIndex = 1;
            this.textBoxInputData.TabStop = false;
            // 
            // buttonFileExpress
            // 
            this.buttonFileExpress.Image = global::Tyuiu.ZairovAR.Sprint6.Task6.V8.Properties.Resources.folder_page;
            this.buttonFileExpress.Location = new System.Drawing.Point(3, 3);
            this.buttonFileExpress.Name = "buttonFileExpress";
            this.buttonFileExpress.Size = new System.Drawing.Size(75, 55);
            this.buttonFileExpress.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonFileExpress, "Открыть файл");
            this.buttonFileExpress.UseVisualStyleBackColor = true;
            this.buttonFileExpress.Click += new System.EventHandler(this.buttonFileExpress_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHelp.Image = global::Tyuiu.ZairovAR.Sprint6.Task6.V8.Properties.Resources.help;
            this.buttonHelp.Location = new System.Drawing.Point(712, 0);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(75, 61);
            this.buttonHelp.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonHelp, "Информация о программе ");
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.Image = global::Tyuiu.ZairovAR.Sprint6.Task6.V8.Properties.Resources.newspaper_add;
            this.buttonFile.Location = new System.Drawing.Point(84, 3);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(75, 55);
            this.buttonFile.TabIndex = 0;
            this.toolTip.SetToolTip(this.buttonFile, "Производит поиск в фале вхождений сиволов \"z\"");
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // openFileDialogTask
            // 
            this.openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 508);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 4 | Вариант 9 | Заиров Артур Ранисович";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxInput_ZAR.ResumeLayout(false);
            this.groupBoxInput_ZAR.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBoxTask_ZAR.ResumeLayout(false);
            this.groupBoxTask_ZAR.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBoxOutput_ZAR.ResumeLayout(false);
            this.groupBoxOutput_ZAR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxTask_ZAR;
        private System.Windows.Forms.TextBox textBoxUslovie;
        private System.Windows.Forms.GroupBox groupBoxOutput_ZAR;
        private System.Windows.Forms.GroupBox groupBoxInput_ZAR;
        private System.Windows.Forms.TextBox textBoxOut;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox textBoxInputData;
        private System.Windows.Forms.Button buttonFileExpress;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

