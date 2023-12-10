using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint6.Task5.V22.Lib;
using System.IO;
namespace Tyuiu.ZairovAR.Sprint6.Task5.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\pfbhj\source\repos\Tyuiu.ZairovAR.Sprint6\Tyuiu.ZairovAR.Sprint6.Task5.V22\bin\Debug\InPutFileTask5V22.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists; 
            Assert.AreEqual(true, fileExists);
        }
    }
}
