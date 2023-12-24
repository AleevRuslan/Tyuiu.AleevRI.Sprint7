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
using Tyuiu.AleevRI.Sprint7.Project.V10.Lib;

namespace Tyuiu.AleevRI.Sprint7.Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int cols;
        static string openFilePath;

        DataService ds = new DataService();


        private void buttonOpenFile_ARI_Click(object sender, EventArgs e)
        {
            openFileDialog_ARI.ShowDialog();
            openFilePath = openFileDialog_ARI.FileName;

            string[,] arrayValues = ds.LoadFromFileData(openFilePath);

            int cols = arrayValues.GetLength(1);
            int rows = arrayValues.GetLength(0);
            dataGridViewOrders_ARI.ColumnCount = cols;
            dataGridViewOrders_ARI.RowCount = rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dataGridViewOrders_ARI.Rows[i].Cells[j].Value = arrayValues[i, j];
                }
            }
        }



        private void buttonAddRows_ARI_ARI_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewOrders_ARI.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_ARI_Click(object sender, EventArgs e)
        {
            saveFileDialog_ARI.FileName = "DataBase.csv";
            saveFileDialog_ARI.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_ARI.ShowDialog();

            string path = saveFileDialog_ARI.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOrders_ARI.RowCount;
            int columns = dataGridViewOrders_ARI.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOrders_ARI.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOrders_ARI.Rows[i].Cells[j].Value;
                    }
                }

                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

        }

        private void buttonDelRows_ARI_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrders_ARI.RowCount != 0)
            {
                int nugno = -1;
                for (int i = 0; i < dataGridViewOrders_ARI.RowCount - 1; i++)
                {
                    for (int j = 0; j < dataGridViewOrders_ARI.ColumnCount - 1; j++)
                    {
                        if (dataGridViewOrders_ARI.Rows[i].Cells[j].Selected == true)
                        {
                            nugno = j;
                            break;
                        }
                    }
                    if (nugno > -1) break;
                }
                if (nugno > -1)
                {
                    if (dataGridViewOrders_ARI.Rows[0].Cells[nugno].Selected == true) MessageBox.Show("Первую строку нельзя удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        var result = MessageBox.Show($"{"Удалить данную строку?" + "\r"}{"Ее невозможно будет восстановить"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            int k = -1; int udal = 0;
                            for (int i = 1; i < dataGridViewOrders_ARI.RowCount - 1; i++)
                            {
                                if (dataGridViewOrders_ARI.Rows[i].Cells[nugno].Selected == true)
                                {
                                    k = i;
                                    break;
                                }
                                if (k > -1) break;
                            }
                            for (int i = 1; i < dataGridViewOrders_ARI.RowCount - 1; i++)
                            {
                                if (dataGridViewOrders_ARI.Rows[i].Cells[nugno].Selected == true) udal++;
                            }
                            for (int r = 0; r < udal; r++) dataGridViewOrders_ARI.Rows.Remove(dataGridViewOrders_ARI.Rows[k]);
                            for (int i = 0; i < dataGridViewOrders_ARI.RowCount - 1; i++)
                            {
                                for (int j = 0; j < dataGridViewOrders_ARI.ColumnCount - 1; j++)
                                {
                                    dataGridViewOrders_ARI.Rows[i].Cells[j].Selected = false;
                                }
                            }
                        }
                    }
                }
                else MessageBox.Show("Выберите строку, которую ходите удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ToolStripMenuItemHelp_ARI_Click(object sender, EventArgs e)
        {
            FormHelp FormHelp = new FormHelp();
            FormHelp.Show();
        }

        private void ToolStripMenuItemInfo_ARI_Click(object sender, EventArgs e)
        {
            FormAbout FormAbout = new FormAbout();
            FormAbout.Show();
        }
    }
}
