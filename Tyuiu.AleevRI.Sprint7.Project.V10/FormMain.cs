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

        public string filePath;
        static int columnIndex;

        DataService ds = new DataService();


        private void buttonOpenFile_ARI_Click(object sender, EventArgs e)
        {
            openFileDialog_ARI.ShowDialog();
            filePath = openFileDialog_ARI.FileName;

            string[,] arrayValues = ds.LoadFromFileData(filePath);

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

            buttonPriceAverage_ARI.Enabled = true;
            buttonPriceMax_ARI.Enabled = true;
            buttonPriceMin_ARI.Enabled = true;
            buttonPriceTotal_ARI.Enabled = true;
            buttonGraphic_ARI.Enabled = true;
            buttonAddRows_ARI_ARI.Enabled = true;
            buttonDelRows_ARI.Enabled = true;
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
                int selectedColumnIndex = -1;
                for (int i = 0; i < dataGridViewOrders_ARI.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewOrders_ARI.ColumnCount; j++)
                    {
                        if (dataGridViewOrders_ARI.Rows[i].Cells[j].Selected == true)
                        {
                            selectedColumnIndex = j;
                            break;
                        }
                    }
                    if (selectedColumnIndex > -1) break;
                }
                if (selectedColumnIndex > -1)
                {
                    var result = MessageBox.Show($"Удалить выбранную строку? Это действие нельзя будет отменить.", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        int deletedRowCount = 0;
                        for (int i = 0; i < dataGridViewOrders_ARI.RowCount; i++)
                        {
                            if (dataGridViewOrders_ARI.Rows[i].Cells[selectedColumnIndex].Selected == true)
                            {
                                dataGridViewOrders_ARI.Rows.RemoveAt(i);
                                i--;
                                deletedRowCount++;
                            }
                        }
                        for (int i = 0; i < dataGridViewOrders_ARI.RowCount; i++)
                        {
                            for (int j = 0; j < dataGridViewOrders_ARI.ColumnCount; j++)
                            {
                                dataGridViewOrders_ARI.Rows[i].Cells[j].Selected = false;
                            }
                        }
                        MessageBox.Show($"Удалено {deletedRowCount} строк.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите строку, которую хотите удалить", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


        private void buttonGraphic_ARI_Click(object sender, EventArgs e)
        {
            FormGraph formGraph = new FormGraph();
            formGraph.Show();
        }

        private void buttonPriceMin_ARI_Click(object sender, EventArgs e)
        {
            textBoxPriceMin_ARI.Text = Convert.ToString(ds.FindMinValueInColumn(filePath, 5));
        }

        private void buttonPriceMax_ARI_Click(object sender, EventArgs e)
        {
            textBoxPriceMax_ARI.Text = Convert.ToString(ds.FindMaxValueInColumn(filePath, 5));
        }

        private void buttonPriceTotal_ARI_Click(object sender, EventArgs e)
        {
            textBoxPriceTotal_ARI.Text = Convert.ToString(ds.FindSumOfColumn(filePath, 5));
        }

        private void buttonPriceAverage_ARI_Click(object sender, EventArgs e)
        {
            textBoxPriceAverage_ARI.Text = Convert.ToString(ds.FindAverageValueInColumn(filePath, 5));
        }
    }
}
