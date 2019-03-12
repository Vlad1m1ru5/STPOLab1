using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp;

namespace IntegrationTestProject1
{
    [TestClass]
    public class IntegrationTest
    {
        // Наличие целого числа в файле
        [TestMethod]
        public void TestMethod_isInSeq()
        {
            formMain formMain1 = new formMain();
            formMain1.textBoxFail.Text = "TheFail.txt";
            bool passed = true;

            /*
             * Тест 1
            */
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "100 101 102");

            formMain1.checkBoxSortQSort.Checked = true;
            formMain1.checkBoxSortShell.Checked = false;

            passed = formMain1.isInSeq(100);

            Assert.AreEqual(true, passed);

            /*
             * Тест 2 
            */
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "102 101 100");

            formMain1.checkBoxSortQSort.Checked = false;
            formMain1.checkBoxSortShell.Checked = true;

            passed = formMain1.isInSeq(100);

            Assert.AreEqual(true, passed);

            /*
             * Тест 3
            */
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "102 101 100");
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.checkBoxSortQSort.Checked = false;
            formMain1.checkBoxSortShell.Checked = true;

            passed = formMain1.isInSeq(100);

            Assert.AreEqual(false, passed);

            /*
             * Тест 4
            */
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "117 150 100");

            formMain1.checkBoxSortQSort.Checked = false;
            formMain1.checkBoxSortShell.Checked = false;

            passed = formMain1.isInSeq(100);

            Assert.AreEqual(false, passed);

            /*
             * Тест 5
            */
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "");

            formMain1.checkBoxSortQSort.Checked = true;
            formMain1.checkBoxSortShell.Checked = false;

            passed = formMain1.isInSeq(100);

            Assert.AreEqual(false, passed);

            /*
             * Тест 6
            */
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "ффф ппп еее");

            formMain1.checkBoxSortQSort.Checked = true;
            formMain1.checkBoxSortShell.Checked = false;

            passed = formMain1.isInSeq(100);

            Assert.AreEqual(false, passed);

            /*
             * Тест 7
            */
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "-111 -134 -101");

            formMain1.checkBoxSortQSort.Checked = false;
            formMain1.checkBoxSortShell.Checked = true;

            passed = formMain1.isInSeq(-100);

            Assert.AreEqual(false, passed);

            /*
             * Тест 8
            */
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "-100 -115 -101");
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.checkBoxSortQSort.Checked = false;
            formMain1.checkBoxSortShell.Checked = true;

            passed = formMain1.isInSeq(-100);

            Assert.AreEqual(false, passed);
            
            formMain1.Dispose();
        } // Конец TestMethod_isInSeq()

        // Выполнение программы
        [TestMethod]
        public void TestMethod_buttonExe_Click()
        {
            formMain formMain1 = new formMain();

            /*
             * Тест 1 
            */
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "101 102 100");

            formMain1.textBoxArg.Text = "100";

            formMain1.checkBoxSortQSort.Checked = false;
            formMain1.checkBoxSortShell.Checked = true;

            formMain1.buttonExe_Click(formMain1.buttonExe, EventArgs.Empty);
            
            Assert.AreEqual("Число найдено", formMain1.finale);

            /*
             * Тест 2
            */
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "101 102 100");

            formMain1.textBoxArg.Text = "-100";

            formMain1.checkBoxSortQSort.Checked = false;
            formMain1.checkBoxSortShell.Checked = true;

            formMain1.buttonExe_Click(formMain1.buttonExe, EventArgs.Empty);

            Assert.AreEqual("Число не найдено", formMain1.finale);

            /*
             * Тест 3
            */
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.WriteAllText(formMain1.textBoxFail.Text, "101 102 100");

            formMain1.textBoxArg.Text = "aaAAaa";

            formMain1.checkBoxSortQSort.Checked = false;
            formMain1.checkBoxSortShell.Checked = true;

            formMain1.buttonExe_Click(formMain1.buttonExe, EventArgs.Empty);

            Assert.AreEqual("Внимание! Проверьте корректность заполнения полей.", formMain1.finale);

            formMain1.Dispose();
        } // Конец TestMethod_buttonExe_Click()

        // Проверка заполнения полей
        [TestMethod]
        public void TestMethod_getFormFilled()
        {
            formMain formMain1 = new formMain();
            bool passed = true;

            /*
             * Тест 1
            */
            formMain1.checkBoxSortShell.Checked = false;
            formMain1.checkBoxSortQSort.Checked = false;
            
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text).Close();
            
            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            System.IO.File.Delete(formMain1.textBoxFail.Text);

            /*
             * Тест 2
            */
            formMain1.checkBoxSortShell.Checked = false;
            formMain1.checkBoxSortQSort.Checked = true;
            
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text).Close();

            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(true, passed);

            System.IO.File.Delete(formMain1.textBoxFail.Text);

            /*
             * Тест 3
            */
            formMain1.checkBoxSortShell.Checked = true;
            formMain1.checkBoxSortQSort.Checked = false;
            
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text).Close();
           
            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(true, passed);

            System.IO.File.Delete(formMain1.textBoxFail.Text);

            /*
             * Тест 4
            */
            formMain1.checkBoxSortShell.Checked = true;
            formMain1.checkBoxSortQSort.Checked = true;
            
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text).Close();
            
            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            System.IO.File.Delete(formMain1.textBoxFail.Text);

            /*
             * Тест 5
            */
            formMain1.checkBoxSortShell.Checked = true;
            formMain1.checkBoxSortQSort.Checked = false;
            
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text).Close();
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            /*
             * Тест 6
            */
            formMain1.checkBoxSortShell.Checked = false;
            formMain1.checkBoxSortQSort.Checked = true;
            
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text).Close();
            
            formMain1.textBoxArg.Text = "1000000";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            System.IO.File.Delete(formMain1.textBoxFail.Text);

            /*
             * Тест 7
            */
            formMain1.checkBoxSortShell.Checked = false;
            formMain1.checkBoxSortQSort.Checked = true;
            
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text).Close();
            
            formMain1.textBoxArg.Text = "0";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            System.IO.File.Delete(formMain1.textBoxFail.Text);

            /*
             * Тест 8
            */
            formMain1.checkBoxSortShell.Checked = true;
            formMain1.checkBoxSortQSort.Checked = false;
            
            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text).Close();
            
            formMain1.textBoxArg.Text = "10aaa";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            System.IO.File.Delete(formMain1.textBoxFail.Text);

            /*
             * Тест 9
            */
            formMain1.checkBoxSortShell.Checked = true;
            formMain1.checkBoxSortQSort.Checked = false;

            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text).Close();

            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(true, passed);

            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.Dispose();
        } // Конец TestMethod_getFormFilled()

    } // Конец IntegrationTest
}
