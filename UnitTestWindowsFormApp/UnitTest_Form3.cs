using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp;

namespace UnitTestWindowsFormApp
{
    [TestClass]
    public class UnitTest_Form3
    {
        [TestMethod]
        public void TestMethod_button1_Click()
        {
            //
            // Тест 1
            //
            FormAnswer formAnswer1 = new FormAnswer();
            Assert.AreEqual(formAnswer1.isClose, false);
            formAnswer1.Dispose();

            //
            // Тест 2
            // 
            FormAnswer formAnswer2 = new FormAnswer();
            formAnswer2.button1_Click(formAnswer2.buttonAnswer, EventArgs.Empty);
            Assert.AreEqual(formAnswer2.isClose, true);
            formAnswer2.Dispose();
        } // Конец TestMethod_button1_Click()

        [TestMethod]
        public void TestMethod_setLabelAnswer()
        {
            FormAnswer formAnswer1 = new FormAnswer();
            String s;

            //
            // Тест 1
            //
            formAnswer1.setLabelAnswer(true);
            s = "Число найдено";
            Assert.AreEqual(formAnswer1.labelAnswer.Text, s);

            //
            // Тест 2
            // 
            formAnswer1.setLabelAnswer(false);
            s = "Число не найдено";
            Assert.AreEqual(formAnswer1.labelAnswer.Text, s);

            formAnswer1.Dispose();
        } // Конец TestMethod_setLabelAnswer()

    } // Конец UnitTest_Form3
}
