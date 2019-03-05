using NUnit.Framework;
using System;
using WindowsFormsApp;

namespace Tests
{
    public class Tests
    {
        //formMain formMain1 = new formMain();
        class testformMain : formMain
        {
        }

            [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}