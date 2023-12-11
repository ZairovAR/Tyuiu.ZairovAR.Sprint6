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
using Tyuiu.ZairovAR.Sprint6.Task7.V1.Lib;
namespace Tyuiu.ZairovAR.Sprint6.Task7.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialogMatrix.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }

        static string openFile;
        static int rows;
        static int columns;

        DataService ds = new DataService();



        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_r[j]);
                }
            }
            return array;
        }


        private void buttonFileExpress_Click(object sender, EventArgs e)
        {
            openFileDialogTask.ShowDialog();
            openFile = openFileDialogTask.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromData(openFile);

            dataGridViewInput.RowCount = rows;
            dataGridViewInput.ColumnCount = columns;
            dataGridViewOutput.RowCount = rows;
            dataGridViewOutput.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
                dataGridViewOutput.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInput.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFile);
            buttonFile.Enabled = true;
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutput.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave.Enabled = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix.ShowDialog();

            string path = saveFileDialogMatrix.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutput.RowCount;
            int columns = dataGridViewOutput.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewOutput.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutput.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInput.RowCount = 50;
            dataGridViewOutput.RowCount = 50;

            dataGridViewInput.ColumnCount = 50;
            dataGridViewOutput.ColumnCount = 50;

            panel2.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInput.Columns[i].Width = 25;
                dataGridViewOutput.Columns[i].Width = 25;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        
    }
}
