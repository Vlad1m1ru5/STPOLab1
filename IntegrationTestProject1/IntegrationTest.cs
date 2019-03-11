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
            bool clicked = true;

            Assert.AreEqual(true, clicked);
        } // Конец TestMethod_isInSeq()

        // Выполнение программы
        [TestMethod]
        public void TestMethod_buttonExe_Click()
        {
            bool clicked = true;

            Assert.AreEqual(true, clicked);
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
            passed = formMain1.checkBoxSortShell.Checked;
            formMain1.checkBoxSortQSort.Checked = false;
            passed = formMain1.checkBoxSortQSort.Checked;

            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text);
            passed = System.IO.File.Exists(formMain1.textBoxFail.Text);
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            /*
             * Тест 2
            */
            formMain1.checkBoxSortShell.Checked = false;
            passed = formMain1.checkBoxSortShell.Checked;
            formMain1.checkBoxSortQSort.Checked = true;
            passed = formMain1.checkBoxSortQSort.Checked;

            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text);
            passed = System.IO.File.Exists(formMain1.textBoxFail.Text);
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            /*
             * Тест 3
            */
            formMain1.checkBoxSortShell.Checked = true;
            passed = formMain1.checkBoxSortShell.Checked;
            formMain1.checkBoxSortQSort.Checked = false;
            passed = formMain1.checkBoxSortQSort.Checked;

            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text);
            passed = System.IO.File.Exists(formMain1.textBoxFail.Text);
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            /*
             * Тест 4
            */
            formMain1.checkBoxSortShell.Checked = true;
            passed = formMain1.checkBoxSortShell.Checked;
            formMain1.checkBoxSortQSort.Checked = true;
            passed = formMain1.checkBoxSortQSort.Checked;

            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text);
            passed = System.IO.File.Exists(formMain1.textBoxFail.Text);
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            /*
             * Тест 5
            */
            formMain1.checkBoxSortShell.Checked = true;
            passed = formMain1.checkBoxSortShell.Checked;
            formMain1.checkBoxSortQSort.Checked = false;
            passed = formMain1.checkBoxSortQSort.Checked;

            formMain1.textBoxFail.Text = "TheFail.txt";
            passed = System.IO.File.Exists(formMain1.textBoxFail.Text);

            formMain1.textBoxArg.Text = "100";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            /*
             * Тест 6
            */
            formMain1.checkBoxSortShell.Checked = false;
            passed = formMain1.checkBoxSortShell.Checked;
            formMain1.checkBoxSortQSort.Checked = true;
            passed = formMain1.checkBoxSortQSort.Checked;

            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text);
            passed = System.IO.File.Exists(formMain1.textBoxFail.Text);
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.textBoxArg.Text = "1000000";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            /*
             * Тест 7
            */
            formMain1.checkBoxSortShell.Checked = false;
            passed = formMain1.checkBoxSortShell.Checked;
            formMain1.checkBoxSortQSort.Checked = true;
            passed = formMain1.checkBoxSortQSort.Checked;

            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text);
            passed = System.IO.File.Exists(formMain1.textBoxFail.Text);
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.textBoxArg.Text = "0";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            /*
             * Тест 8
            */
            formMain1.checkBoxSortShell.Checked = true;
            passed = formMain1.checkBoxSortShell.Checked;
            formMain1.checkBoxSortQSort.Checked = false;
            passed = formMain1.checkBoxSortQSort.Checked;

            formMain1.textBoxFail.Text = "TheFail.txt";
            System.IO.File.Create(formMain1.textBoxFail.Text);
            passed = System.IO.File.Exists(formMain1.textBoxFail.Text);
            System.IO.File.Delete(formMain1.textBoxFail.Text);

            formMain1.textBoxArg.Text = "10aaa";
            passed = formMain1.getFormFilled();

            Assert.AreEqual(false, passed);

            formMain1.Dispose();
        } // Конец TestMethod_getFormFilled()

    } // Конец IntegrationTest
}
