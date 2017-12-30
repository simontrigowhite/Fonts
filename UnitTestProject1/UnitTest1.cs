using System;
using System.Collections.Generic;
using System.Drawing;

using Fonts;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var f = Class1.GetFont();

            Assert.AreEqual("Wonder Mail", f.Name);

        }


    }
}
