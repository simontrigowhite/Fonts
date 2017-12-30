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
            var f = GetSSerifeFont();

            Assert.AreEqual("Microsoft Sans Serif", f.Name); // but why does it show up as MS Sans Serif in the font viewer?
            Assert.AreEqual("", f.SystemFontName);
            Assert.AreEqual(null, f.OriginalFontName);

            
        }

        private static Font GetSSerifeFont()
        {
            List<string> fonts = new List<string>();

            FontFamily wonderFon = null;
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
                if (font.Name == "Microsoft Sans Serif")
                {
                    wonderFon = font;
                }
            }

            //Console.WriteLine(wonderFon.ToString());

            Assert.AreEqual(256, fonts.Count);

            foreach (string name in fonts)
            {
                //Console.WriteLine(name);
            }

            Font f = new Font(wonderFon, 20);

            //return f;
            return f;
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
