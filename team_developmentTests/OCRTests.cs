using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace Lib.Tests
{
    [TestClass()]
    public class OCRTests
    {
        [TestMethod()]
        public void GetValidateCodeTest()
        {
            string[] files = { "./resource/ValidateCode/picture0.bmp", "./resource/ValidateCode/picture1.bmp", "./resource/ValidateCode/picture2.bmp", "./resource/ValidateCode/picture3.bmp", "./resource/ValidateCode/picture4.bmp", "./resource/ValidateCode/picture5.bmp", "./resource/ValidateCode/picture6.bmp", "./resource/ValidateCode/picture7.bmp", "./resource/ValidateCode/picture8.bmp", "./resource/ValidateCode/picture9.bmp", "./resource/ValidateCode/picture10.bmp" };
            string[] trueResult = { "9v7n", "YTBz", "mAMY", "xftB", "TpD2", "KM7c", "tav3", "gzXe", "Df9E", "ZWm5", "b4ZG" };
            int num = 0;
            for (int i = 0; i < trueResult.Length; ++i) {
                FileStream fin = File.OpenRead(files[i]);
                int filelength = 0;
                filelength = (int)fin.Length; 
                Byte[] image = new Byte[filelength]; 
                fin.Read(image, 0, filelength); 
                System.Drawing.Image r = System.Drawing.Image.FromStream(fin);
                fin.Close();
                Bitmap img = new Bitmap(r);
                if (OCR.GetValidateCode(img) == trueResult[i]) {
                    ++num;
                }
            }
            Assert.IsTrue(num  > 0);
        }
    }
}