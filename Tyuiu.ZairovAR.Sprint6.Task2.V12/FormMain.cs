using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZairovAR.Sprint6.Task2.V12.Lib;
namespace Tyuiu.ZairovAR.Sprint6.Task2.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonStartCode_ZAR_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxInputStartStep_ZAR.Text);
                int stopValue = Convert.ToInt32(textBoxInputStopStep_ZAR.Text);


                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                this.chartFunction_ZAR.Titles.Add("График функции");

                this.chartFunction_ZAR.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_ZAR.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_ZAR.Rows.Add(Convert.ToString(startValue), Convert.ToString(valueArray[i]));

                    this.chartFunction_ZAR.Series[0].Points.AddXY(startValue, valueArray[i]);

                    startValue++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSpravka_ZAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-2 Заиров Артур Ранисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonStartCode_ZAR_MouseEnter(object sender, EventArgs e)
        {
            buttonStartCode_ZAR.BackColor = Color.Red;
        }

        private void buttonStartCode_ZAR_MouseDown(object sender, MouseEventArgs e)
        {
            buttonStartCode_ZAR.BackColor = Color.Blue;
        }

        private void buttonStartCode_ZAR_MouseLeave(object sender, EventArgs e)
        {
            buttonStartCode_ZAR.BackColor = Color.Green;
        }
    }
}
