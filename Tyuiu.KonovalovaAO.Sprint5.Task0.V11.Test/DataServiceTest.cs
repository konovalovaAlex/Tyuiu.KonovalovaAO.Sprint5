using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO; 
using Tyuiu.KonovalovaAO.Sprint5.Task0.V11.Lib;
namespace Tyuiu.KonovalovaAO.Sprint5.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\user\source\repos\Tyuiu.KonovalovaAO.Sprint5\Tyuiu.KonovalovaAO.Sprint5.Task0.V11\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
