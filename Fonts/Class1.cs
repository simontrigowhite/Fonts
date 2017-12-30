using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonts
{
    public class Class1
    {
        public static Font GetWonderMailFont()
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
                Console.WriteLine(name);
            }

            Font f = new Font(wonderFon, 20);

            WriteToImage(wonderFon);

            return f;
        }

        public static Font GetSSerifeFont()
        {
            List<string> fonts = new List<string>();
            List<FontFamily> fontFamilies = new List<FontFamily>();

            FontFamily wonderFon = null;
            foreach (FontFamily font2 in System.Drawing.FontFamily.Families)
            {
                fonts.Add(font2.Name);
                fontFamilies.Add(font2);

                if (font2.Name == "Microsoft Sans Serif")
                {
                    wonderFon = font2;
                }
            }

            //Console.WriteLine(wonderFon.ToString());

            //Assert.AreEqual(256, fonts.Count);

            foreach (string name in fonts)
            {
                //Console.WriteLine(name);
            }

            //Font f2 = new Font(wonderFon, 20);

            return Class1.WriteToImage(wonderFon);

        }
        
        
        public static Font GetFont(string fontName)
        {
            //string fontName = "YourFont.ttf";
            PrivateFontCollection pfcoll = new PrivateFontCollection();

            //put a font file under a Fonts directory within your application root


            try
            {
                pfcoll.AddFontFile(fontName);

            }
            catch (Exception e)
            {

                throw e;
            }

            FontFamily ff = pfcoll.Families[0];

            return WriteToImage(ff);
        }

        public static Font WriteToImage(FontFamily ff)
        {

            string firstText = "Hello";
            string secondText = "Friend!";

            PointF firstLocation = new PointF(10f, 10f);
            PointF secondLocation = new PointF(10f, 200f);
            //put an image file under a Images directory within your application root
            string imageFilePath = @"c:\Users\Simon\Desktop\blank.jpg";
            Bitmap bitmap = (Bitmap)System.Drawing.Image.FromFile(imageFilePath); //load the image file

            Font font;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                //using (
                Font f = new Font(ff, 80, FontStyle.Regular);
                {
                    graphics.DrawString(firstText, f, Brushes.Blue, firstLocation);
                    graphics.DrawString(secondText, f, Brushes.Green, secondLocation);
                }

                font = f;
            }
            //save the new image file within Images directory
            bitmap.Save(@"c:\Users\Simon\Desktop\" + System.Guid.NewGuid() + ".jpg");
            //Response.Write("A new image has been created!");            

            return font;
        }
    }
}
