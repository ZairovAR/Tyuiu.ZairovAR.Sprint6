using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ZairovAR.Sprint6.Task6.V8.Lib;
using System.IO;
namespace Tyuiu.ZairovAR.Sprint6.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\pfbhj\source\repos\Tyuiu.ZairovAR.Sprint6\Tyuiu.ZairovAR.Sprint6.Task6.V8\bin\Debug\InPutFileTask6V8.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
