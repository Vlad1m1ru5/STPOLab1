using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp;

namespace UnitTestWindowsFormApp
{
    [TestClass]
    public class UnitTest_Form1
    {
        [TestMethod]
        public void TestMethod_partition()
        {
            // Тестовые параметры 
            formMain formMain1 = new formMain();
            int[] arr = { 4, 3, 2, 1 };
            int res = 0;

            // Тесты
            Assert.AreEqual(formMain1.partition(arr, 0, 3), res);
        }

        [TestMethod]
        public void TestMethod_ShellSort()
        {
            // Тестовые параметры
            formMain formMain1 = new formMain();
            int[] arr = { 1, 2, 3 };
            int[] sortarr = { 1, 2, 3 };

            // Тесты
            //formMain1.ShellSort(arr);
            //Assert.IsTrue(arr.Equals(sortarr));
        }
    }
}
