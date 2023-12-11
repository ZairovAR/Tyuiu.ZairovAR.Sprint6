using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ZairovAR.Sprint6.Task7.V1.Lib;
namespace Tyuiu.ZairovAR.Sprint6.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\pfbhj\source\repos\Tyuiu.ZairovAR.Sprint6\Tyuiu.ZairovAR.Sprint6.Task7.V1\bin\Debug\InPutFileTask7V1.csv";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
