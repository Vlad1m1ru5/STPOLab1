using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp;

namespace IntegrationTestProject1
{
    [TestClass]
    public class IntegrationTest
    {
        [TestMethod]
        public void TestMethod_button1_Click_1()
        {
            formMain formMain1 = new formMain();
            
            formMain1.Dispose();
        } // Конец TestMethod_button1_Click_1()
    }
}
