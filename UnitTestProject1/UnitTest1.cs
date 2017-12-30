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
        public void TestSSerife()
        {
            //var f = Class1.GetFont(@"sserife.fon"); // doesn't read the file
            var f = Class1.GetSSerifeFont();

            Assert.AreEqual("MS Sans Serif", f.Name);
            Assert.AreEqual("", f.SystemFontName);
            Assert.AreEqual(null, f.OriginalFontName);

            // but image show it is Microsoft Sans Serif (which is micross.ttf), not MS Sans Serif (which is sserife.fon)
            
        }



        [TestMethod]
        public void TestAgencyFB()
        {
            var f = Class1.GetFont(@"AGENCYR.TTF");

            Assert.AreEqual("Agency FB", f.Name);
            Assert.AreEqual("", f.SystemFontName);
            Assert.AreEqual(null, f.OriginalFontName);
        }


        [TestMethod]
        public void TestWonderMail()
        {
            var f = Class1.GetWonderMailFont();

            Assert.AreEqual("Wonder Mail", f.Name);
            Assert.AreEqual("", f.SystemFontName);
            Assert.AreEqual(null, f.OriginalFontName);
        }


    }
}
