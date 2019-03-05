using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp;

namespace UnitTestWindowsFormApp
{
    [TestClass]
    public class UnitTest_Form2
    {
        [TestMethod]
        public void TestMethod_button1_Click()
        {
            //
            // Тест 1
            //
            FormAlert formAlert1 = new FormAlert();
            Assert.AreEqual(formAlert1.isClose, false);
            formAlert1.Dispose();

            //
            // Тест 2
            // 
            FormAlert formAlert2 = new FormAlert();
            formAlert2.button1_Click(formAlert2.button1, EventArgs.Empty);
            Assert.AreEqual(formAlert2.isClose, true);
            formAlert2.Dispose();

        } // Конец TestMethod_button1_Click()

    } // Конец UnitTest_Form2
}
