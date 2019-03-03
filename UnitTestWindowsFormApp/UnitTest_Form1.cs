using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp;

namespace UnitTestWindowsFormApp
{
    [TestClass]
    public class UnitTest_Form1
    {
        // Поиск опорного элемента
        [TestMethod]
        public void TestMethod_partition()
        {
            formMain formMain1 = new formMain();
            int[] arr;
            int res;

            //
            // Тест 1 
            //
            arr = new int[4] { 4, 3, 2, 1 };
            res = 0;

            try
            {
                Assert.AreEqual(formMain1.partition(arr, 0, 3), res);
            }
            finally
            {
                arr = null;
            }

            //
            // Тест 2
            //
            arr = new int[4] { 1, 2, 3, 4 };
            res = 3;

            try
            {
                Assert.AreEqual(formMain1.partition(arr, 0, 3), res);
            }
            finally
            {
                arr = null;
            }

            //
            // Тест 3
            //
            arr = new int[1] { 0 };
            res = 0;
            try
            {
                Assert.AreEqual(formMain1.partition(arr, 0, 0), res);
            }
            finally
            {
                arr = null;
            }

            //
            // Тест 4
            //
            arr = new int[5] { 3, 5, 2, 1, 4};
            res = 3;
            try
            {
                Assert.AreEqual(formMain1.partition(arr, 0, 4), res);
            }
            finally
            {
                arr = null;
            }

            formMain1.Dispose();
        } // Конец TestMethod_partition()

        // Сортировка шелла
        [TestMethod]
        public void TestMethod_ShellSort()
        {
            formMain formMain1 = new formMain();
            int[] arr;
            int[] sortarr;

            //
            // Тест 1
            //
            arr = new int[3] { 3, 2, 1 };
            sortarr = new int[3] { 1, 2, 3 };

            try
            {
                formMain1.ShellSort(arr);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            //
            // Тест 2
            //
            arr = new int[3] { 1, 5, 7 };
            sortarr = new int[3] { 1, 5, 7 };

            try
            {
                formMain1.ShellSort(arr);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            //
            // Тест 3
            //
            arr = new int[5] { 0, 0, 0, 0, 0 };
            sortarr = new int[5] { 0, 0, 0, 0, 0 };

            try
            {
                formMain1.ShellSort(arr);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            //
            // Тест 4
            //
            arr = new int[1] { 5 };
            sortarr = new int[1] { 5 };

            try
            {
                formMain1.ShellSort(arr);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            //
            // Тест 5
            //
            arr = new int[4] { 3, 0, -10, 1 };
            sortarr = new int[4] { -10, 0, 1, 3 };

            try
            {
                formMain1.ShellSort(arr);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            formMain1.Dispose();
        } // Конец TestMethod_ShellSort()

        // Сортировка быстрая (Хоара)
        [TestMethod]
        public void TestMethod_Quicksort()
        {
            formMain formMain1 = new formMain();
            int[] arr;
            int[] sortarr;

            //
            // Тест 1
            //
            arr = new int[3] { 3, 2, 1 };
            sortarr = new int[3] { 1, 2, 3 };

            try
            {
                formMain1.QuickSort(arr, 0, 2);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            //
            // Тест 2
            //
            arr = new int[3] { 1, 5, 7 };
            sortarr = new int[3] { 1, 5, 7 };

            try
            {
                formMain1.QuickSort(arr, 0, 2);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            //
            // Тест 3
            //
            arr = new int[5] { 0, 0, 0, 0, 0 };
            sortarr = new int[5] { 0, 0, 0, 0, 0 };

            try
            {
                formMain1.QuickSort(arr, 0, 4);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            //
            // Тест 4
            //
            arr = new int[1] { 5 };
            sortarr = new int[1] { 5 };

            try
            {
                formMain1.QuickSort(arr, 0, 0);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            //
            // Тест 5
            //
            arr = new int[4] { 3, 0, -10, 1 };
            sortarr = new int[4] { -10, 0, 1, 3 };

            try
            {
                formMain1.QuickSort(arr, 0, 3);
                CollectionAssert.AreEqual(sortarr, arr);
            }
            finally
            {
                arr = null;
                sortarr = null;
            }

            formMain1.Dispose();
        } // Конец TestMethod_Quicksort()
        
    } // Конец UnitTest_Form1
}
