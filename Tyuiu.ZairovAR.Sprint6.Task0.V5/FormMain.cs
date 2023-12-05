using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZairovAR.Sprint6.Task0.V5.Lib;
namespace Tyuiu.ZairovAR.Sprint6.Task0.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }




        private void buttonVipolnit_ZAR_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();


            try
            {
                textBoxResult_ZAR.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInputX_ZAR.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonQuestion_ZAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-23-2 Заиров Артур Ранисович", "Сообщение");
        }

        private void textBoxInputX_ZAR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
    }
}
