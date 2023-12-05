﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ZairovAR.Sprint6.Task3.V10.Lib;
namespace Tyuiu.ZairovAR.Sprint6.Task3.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] { { -17, 6, -19, 6, -13 },
                                           { -19, 3, 12, -11, 19 },
                                           { -20, 11, 9, 19, -19 },
                                           { -20, 10, -9, 17, 9 },
                                           { -4, 9, -8, 13, -8 } };

        private void buttonStartCode_ZAR_Click(object sender, EventArgs e)
        {
            int[,] matrixres = ds.Calculate(matrix);

            int rows = matrixres.GetUpperBound(0) + 1;
            int columns = matrixres.Length / rows;

            dataGridViewOutputMatrix_ZAR.ColumnCount = columns;
            dataGridViewOutputMatrix_ZAR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutputMatrix_ZAR.Columns[i].Width = 50;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutputMatrix_ZAR.Rows[i].Cells[j].Value = Convert.ToString(matrixres[i, j]);
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewInputMatrix_ZAR.ColumnCount = columns;
            dataGridViewInputMatrix_ZAR.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInputMatrix_ZAR.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInputMatrix_ZAR.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonSpravka_ZAR_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-2 Заиров Артур Ранисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
