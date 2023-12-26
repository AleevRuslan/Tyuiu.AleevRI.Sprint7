using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AleevRI.Sprint7.Project.V10.Lib;

namespace Tyuiu.AleevRI.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\rusal\source\repos\Tyuiu.AleevRI.Sprint7\Tyuiu.AleevRI.Sprint7.Project.V10\bin\Debug\DataBase.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string strX = @"C:\Users\rusal\source\repos\Tyuiu.AleevRI.Sprint7\Tyuiu.AleevRI.Sprint7.Project.V10\bin\Debug\DataBase.csv";
            int res = ds.FindMinValueInColumn(strX,5);
            int wait = 2000;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();

            string strX = @"C:\Users\rusal\source\repos\Tyuiu.AleevRI.Sprint7\Tyuiu.AleevRI.Sprint7.Project.V10\bin\Debug\DataBase.csv";
            int res = ds.FindMaxValueInColumn(strX, 5);
            int wait = 9000;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();

            string strX = @"C:\Users\rusal\source\repos\Tyuiu.AleevRI.Sprint7\Tyuiu.AleevRI.Sprint7.Project.V10\bin\Debug\DataBase.csv";
            int res = ds.FindSumOfColumn(strX, 5);
            int wait = 109310;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();

            string strX = @"C:\Users\rusal\source\repos\Tyuiu.AleevRI.Sprint7\Tyuiu.AleevRI.Sprint7.Project.V10\bin\Debug\DataBase.csv";
            double res = ds.FindAverageValueInColumn(strX, 5);
            double wait = 5465.5;

            Assert.AreEqual(wait, res);
        }
    }


}