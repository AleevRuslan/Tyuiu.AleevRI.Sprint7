using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.AleevRI.Sprint7.Project.V10.Lib
{
    public class DataService
    {
        public string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            string[,] arrayValues = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] lineValues = lines[i].Split(';');

                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = lineValues[j];
                }
            }

            return arrayValues;
        }

        public int FindMinValueInColumn(string filePath, int columnIndex)
        {
            string data = File.ReadAllText(filePath);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] row = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int[] values = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                string valueStr = matrix[i, columnIndex];
                int value;
                if (int.TryParse(valueStr, out value))
                {
                    values[i] = value;
                }
            }

            int minValue = int.MaxValue;

            for (int i = 0; i < values.Length; i++)
            {
                int currentValue = values[i];
                if (currentValue < minValue && currentValue != 0)
                {
                    minValue = currentValue;
                }
            }

            return minValue;
        }

        public int FindMaxValueInColumn(string filePath, int columnIndex)
        {
            string data = File.ReadAllText(filePath);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] row = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int[] values = new int[rows - 1];

            for (int i = 1; i < rows; i++)
            {
                values[i - 1] = Convert.ToInt32(matrix[i, columnIndex]);
            }

            int maxValue = int.MinValue;

            for (int i = 0; i < values.Length; i++)
            {
                int currentValue = values[i];
                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }
            }

            return maxValue;
        }

        public int FindSumOfColumn(string filePath, int columnIndex)
        {
            string data = File.ReadAllText(filePath);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] row = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                string valueStr = matrix[i, columnIndex];
                int value;
                if (int.TryParse(valueStr, out value))
                {
                    sum += value;
                }
            }

            return sum;
        }

        public double FindAverageValueInColumn(string filePath, int columnIndex)
        {
            string data = File.ReadAllText(filePath);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] row = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            double sum = 0;
            int count = 0;

            for (int i = 0; i < rows; i++)
            {
                string valueStr = matrix[i, columnIndex];
                int value;
                if (int.TryParse(valueStr, out value))
                {
                    sum += value;
                    count++;
                }
            }

            if (count > 0)
            {
                double average = sum / count;
                return Math.Round(average, 2);
            }

            return 0; // Если нет значений в столбце, возвращаем 0
        }
    }
}

