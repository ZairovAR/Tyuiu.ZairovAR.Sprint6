using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ZairovAR.Sprint6.Task5.V22.Lib;
namespace Tyuiu.ZairovAR.Sprint6.Task5.V22
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = @"C:\Users\pfbhj\source\repos\Tyuiu.ZairovAR.Sprint6\Tyuiu.ZairovAR.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";
        private void buttonStartCode_ZAR_Click(object sender, EventArgs e)
        {
            dataGridViewXOX.ColumnCount = 2;
            dataGridViewXOX.Columns[0].Width = 20;
            dataGridViewXOX.Columns[1].Width = 50;

            this.chart_ZAR.ChartAreas[0].AxisX.Title = "Ось X";
            this.chart_ZAR.ChartAreas[0].AxisY.Title = "Ось Y";

            chart_ZAR.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewXOX.Rows.Add(i.ToString(), numsMass[i].ToString());
                chart_ZAR.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonSave_ZAR_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonSpravka_ZAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-2 Заиров Артур Ранисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
