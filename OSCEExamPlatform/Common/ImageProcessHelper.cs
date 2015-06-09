using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace Tellyes.Common
{
  public  class ImageProcessHelper
    {

      /// <summary>
        /// 将图像等比缩放
      /// </summary>
      /// <param name="imageStream"></param>
      /// <param name="width"></param>
      /// <param name="height"></param>
      /// <returns></returns>
      public static byte[] ZoomInOut(System.IO.Stream imageStream, int MaxWidth, int MaxHeight)
      {
          System.IO.MemoryStream OutPutImageStream = new System.IO.MemoryStream();
          System.Drawing.Image initImage = System.Drawing.Image.FromStream(imageStream, true);
          System.Drawing.Image templateImage = new System.Drawing.Bitmap(MaxWidth, MaxHeight);
          System.Drawing.Graphics templateG = System.Drawing.Graphics.FromImage(templateImage);
          templateG.Clear(Color.White);
          templateG.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;

           //原图高宽均小于模板高宽
           if (initImage.Width <= MaxWidth && initImage.Height <= MaxHeight)
           {
                   int X_Start = (MaxWidth - initImage.Width)/2;
                   int Y_Start = (MaxHeight - initImage.Height)/2;
                   templateG.DrawImage(initImage, new System.Drawing.Rectangle(X_Start, Y_Start, initImage.Width, initImage.Height), new System.Drawing.Rectangle(0, 0, initImage.Width, initImage.Height), System.Drawing.GraphicsUnit.Pixel);                 
           }
           //原始图高大于模板高度或原始图宽大于模板高度
           else
           {
               //模版的宽高比例
               double templateRate = (double)MaxWidth / MaxHeight;
               //原图片的宽高比例
               double initRate = (double)initImage.Width / initImage.Height;

               //原图与模版比例相等，从0,0坐标直接缩放
               if (templateRate == initRate)
               {
                   templateG.DrawImage(initImage, new System.Drawing.Rectangle(0, 0, initImage.Width, initImage.Height), new System.Drawing.Rectangle(0, 0, initImage.Width, initImage.Height), System.Drawing.GraphicsUnit.Pixel);    
               }
               else
               {
                   int X_Start ;
                   int Y_Start ;
                   //缩略图宽、高计算
                   double newWidth = initImage.Width;
                   double newHeight = initImage.Height;

                   //宽大于高或宽等于高（横图或正方）
                   if (initImage.Width > initImage.Height || initImage.Width == initImage.Height)
                   {
                       //如果宽大于模版
                       if (initImage.Width > MaxWidth)
                       {
                           //宽按模版，高按比例缩放
                           newWidth = MaxWidth;
                           newHeight = initImage.Height * Convert.ToDouble(( Convert.ToDouble(MaxWidth) / Convert.ToDouble(initImage.Width)));
                          
                       }
                       X_Start = 0;
                       Y_Start = (int)(MaxHeight - newHeight) / 2;
                   }
                   //高大于宽（竖图）
                   else
                   {
                       //如果高大于模版
                       if (initImage.Height > MaxHeight)
                       {
                           //高按模版，宽按比例缩放
                           newHeight = MaxHeight;
                           newWidth = initImage.Width * Convert.ToDouble(Convert.ToDouble(MaxHeight) / Convert.ToDouble(initImage.Height));                          
                       }
                       X_Start = (int)(MaxWidth - newWidth) / 2;
                       Y_Start = 0;
                   }

                   templateG.DrawImage(initImage, new System.Drawing.Rectangle(X_Start, Y_Start, Convert.ToInt32(newWidth), Convert.ToInt32(newHeight)), new System.Drawing.Rectangle(0, 0, initImage.Width, initImage.Height), System.Drawing.GraphicsUnit.Pixel); 
               }               
           }
           templateImage.Save(OutPutImageStream, System.Drawing.Imaging.ImageFormat.Png);
           initImage.Dispose();
           templateImage.Dispose();
           templateG.Dispose();
          return OutPutImageStream.ToArray();
      }

    }
}
