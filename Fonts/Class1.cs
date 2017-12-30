using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonts
{
    public class Class1
    {
        public static Font GetFont()
        {
            List<string> fonts = new List<string>();

            FontFamily wonderFon = null;
            foreach (FontFamily font in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font.Name);
                if (font.Name == "Wonder Mail")
                {
                    wonderFon = font;
                }
            }

            Console.WriteLine(wonderFon.ToString());

            //Assert.AreEqual(256, fonts.Count);
            foreach (string name in fonts)
            {
                //Console.WriteLine(name);
            }

            Font f = new Font(wonderFon, 20);
            return f;
        }
    }
}
