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

            return f;
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

            string firstText = "Hello";
            string secondText = "Friend!";

            PointF firstLocation = new PointF(10f, 10f);
            PointF secondLocation = new PointF(10f, 50f);
            //put an image file under a Images directory within your application root
            string imageFilePath = @"c:\Users\Simon\Desktop\YourImage.jpg";
            Bitmap bitmap = (Bitmap) System.Drawing.Image.FromFile(imageFilePath);//load the image file

            Font font;
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                //using (
                Font f = new Font(ff, 14, FontStyle.Bold);
                {
                    graphics.DrawString(firstText, f, Brushes.Blue, firstLocation);
                    graphics.DrawString(secondText, f, Brushes.Red, secondLocation);

                }

                font = f;
            }
            //save the new image file within Images directory
            bitmap.Save(@"c:\Users\Simon\Desktop\" + System.Guid.NewGuid() + ".jpg");
            //Response.Write("A new image has been created!");            

            return font;
        }
        
        //public static Font GetAgencyFBFont()
        //{
        //    string fontName = "YourFont.ttf";
        //    PrivateFontCollection pfcoll = new PrivateFontCollection();

        //    //put a font file under a Fonts directory within your application root


        //    try
        //    {
        //        pfcoll.AddFontFile(@"AGENCYR.TTF");

        //    }
        //    catch (Exception e)
        //    {
                
        //        throw e;
        //    }

        //    FontFamily ff = pfcoll.Families[0];
            
        //    string firstText = "Hello";
        //    string secondText = "Friend!";

        //    PointF firstLocation = new PointF(10f, 10f);
        //    PointF secondLocation = new PointF(10f, 50f);
        //    //put an image file under a Images directory within your application root
        //    string imageFilePath = @"c:\Users\Simon\Desktop\YourImage.jpg";
        //    Bitmap bitmap = (Bitmap) System.Drawing.Image.FromFile(imageFilePath);//load the image file

        //    Font sserifeFont;
        //    using (Graphics graphics = Graphics.FromImage(bitmap))
        //    {
        //        //using (
        //        Font f = new Font(ff, 14, FontStyle.Bold);
        //        {
        //            graphics.DrawString(firstText, f, Brushes.Blue, firstLocation);
        //            graphics.DrawString(secondText, f, Brushes.Red, secondLocation);

        //        }

        //        sserifeFont = f;
        //    }
        //    //save the new image file within Images directory
        //    bitmap.Save(@"c:\Users\Simon\Desktop\" + System.Guid.NewGuid() + ".jpg");
        //    //Response.Write("A new image has been created!");            

        //    return sserifeFont;
        //}
    }
}
