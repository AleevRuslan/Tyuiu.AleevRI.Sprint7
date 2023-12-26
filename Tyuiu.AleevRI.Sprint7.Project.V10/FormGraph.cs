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
    public partial class FormGraph : Form
    {
        public FormGraph()
        {
            InitializeComponent();
        }



        DataService ds = new DataService();

        private void buttonBack_ARI_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonGraphic_ARI_Click(object sender, EventArgs e)
        {
            chartPrice_ARI.ChartAreas[0].AxisX.Interval = 1;
            chartPrice_ARI.ChartAreas[0].AxisY.Interval = 1000;
            chartPrice_ARI.Series[0].Points.Clear();
            string filePath = @"C:\Users\rusal\source\repos\Tyuiu.AleevRI.Sprint7\Tyuiu.AleevRI.Sprint7.Project.V10\bin\Debug\DataBase.csv"; // указываете путь к Вашему файлу

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split(';');
                string name = data[0]; // первый элемент в строке - имя
                string cost = data[data.Length - 1]; // последний элемент в строке - стоимость
                chartPrice_ARI.Series[0].Points.AddXY(name, cost);
            }
        }
    }
}

