﻿using System;
using System.Threading;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp;

namespace CUIT
{
    [TestClass]
    public class VisuaTest
    {
        [TestMethod]
        public void TestMethod_formAnswer()
        {
            /* Тест 1 */
            using (formMain fm1 = new formMain())
            {
                fm1.textBoxArg.Text = "100";
                fm1.textBoxFail.Text = "TempFile.txt";
                File.WriteAllText(fm1.textBoxFail.Text, "102 101 100");
                fm1.checkBoxSortQSort.Checked = true;
                fm1.checkBoxSortShell.Checked = false;
                
                fm1.buttonExe_Click(fm1.buttonExe, EventArgs.Empty);
                fm1.ShowDialog();

                Assert.AreEqual("Число найдено", fm1.finale);
            }

            /* Тест 2 */
            using (formMain fm1 = new formMain())
            {            
                fm1.textBoxArg.Text = "-105";
                fm1.textBoxFail.Text = "TempFile.txt";
                File.WriteAllText(fm1.textBoxFail.Text, "102 101 100");
                fm1.checkBoxSortQSort.Checked = true;
                fm1.checkBoxSortShell.Checked = false;

                fm1.buttonExe_Click(fm1.buttonExe, EventArgs.Empty);
                fm1.ShowDialog();

                Assert.AreEqual("Число не найдено", fm1.finale);
            }

        } // Конец TestMethod_formAnswer()

        [TestMethod]
        public void TestMethod_formAlert()
        {
            /* Тест 1 */
            using(formMain fm = new formMain())
            {
                fm.textBoxArg.Text = "aaaa";
                fm.textBoxFail.Text = "TempFile.txt";
                File.WriteAllText(fm.textBoxFail.Text, "102 101 100");
                fm.checkBoxSortQSort.Checked = true;
                fm.checkBoxSortShell.Checked = false;

                fm.buttonExe_Click(fm.buttonExe, EventArgs.Empty);
                fm.ShowDialog();

                Assert.AreEqual("Внимание! Проверьте корректность заполнения полей.", fm.finale);
            }

            /* Тест 2 */
            using (formMain fm = new formMain())
            {
                fm.textBoxArg.Text = "100";
                fm.textBoxFail.Text = "ToDelete.txt";
                File.WriteAllText(fm.textBoxFail.Text, "102 101 100");
                File.Delete(fm.textBoxFail.Text);
                fm.checkBoxSortQSort.Checked = true;
                fm.checkBoxSortShell.Checked = false;

                fm.buttonExe_Click(fm.buttonExe, EventArgs.Empty);
                fm.ShowDialog();

                Assert.AreEqual("Внимание! Проверьте корректность заполнения полей.", fm.finale);
            }

            /* Тест 3 */
            using (formMain fm = new formMain())
            {
                fm.textBoxArg.Text = "100";
                fm.textBoxFail.Text = "TempFile.txt";
                File.WriteAllText(fm.textBoxFail.Text, "100 102 134 156 234 2367 999");
                fm.checkBoxSortQSort.Checked = true;
                fm.checkBoxSortShell.Checked = true;

                fm.buttonExe_Click(fm.buttonExe, EventArgs.Empty);
                fm.ShowDialog();

                Assert.AreEqual("Внимание! Проверьте корректность заполнения полей.", fm.finale);
            }

        } // Конец TestMethod_formAlert()

    } // Конец VisualTest
}
