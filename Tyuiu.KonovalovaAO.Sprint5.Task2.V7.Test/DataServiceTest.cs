using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KonovalovaAO.Sprint5.Task2.V7.Lib;
namespace Tyuiu.KonovalovaAO.Sprint5.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.KonovalovaAO.Sprint5\Tyuiu.KonovalovaAO.Sprint5.Task2.V7\bin\Debug\OutPutFileTask2.scv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
