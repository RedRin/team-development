using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronOcr;
using System.Drawing;

namespace Lib
{
    public static class OCR
    {
        public static string GetValidateCode(Bitmap img) {
            Log.log.Info("Getting validateCode from image");
            Threshold(ref img, 100);
            var Ocr = new AdvancedOcr() { Language = IronOcr.Languages.English.OcrLanguagePack };
            var Results = Ocr.Read(img);
            return Results.Text;
        }
        private static void Threshold(ref Bitmap img, int bounce)
        {
            Log.log.Info("Processing the Image : transform an image into a binary image.");
            for (int i = 0; i < img.Width; ++i)
            {
                for (int j = 0; j < img.Height; ++j)
                {
                    Color pixelcolor = img.GetPixel(i, j);
                    int grey = ((int)pixelcolor.R + pixelcolor.G + pixelcolor.B) / 3;
                    if (grey > bounce)
                    {
                        grey = 255;
                    }
                    else grey = 0;
                    img.SetPixel(i, j, Color.FromArgb(255, grey, grey, grey));
                }
            }
        }
    }
}