using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.google.zxing.qrcode;
using com.google.zxing;
using com.google.zxing.common;
using ByteMatrix = com.google.zxing.common.ByteMatrix;
using EAN13Writer = com.google.zxing.oned.EAN13Writer;
using EAN8Writer = com.google.zxing.oned.EAN8Writer;
using MultiFormatWriter = com.google.zxing.MultiFormatWriter;
using System.Drawing;
using System.IO;

namespace Maticsoft.Common
{
    /// <summary>
    /// 二维码生成类
    /// </summary>
    public class TwoDimension
    {
        /// <summary>
        /// 生成二维码信息
        /// </summary>
        /// <param name="InsertContent">二维码信息中嵌入的内容</param>
        /// <returns></returns>
        public static Byte[] GenerateTwoDimension(string InsertContent)
        {

            Byte[] twoDimensionByte = { };
            Bitmap twoDimensionBitmap = new Bitmap(200, 200);
            try
            {
                if (!string.IsNullOrEmpty(InsertContent))
                {
                    ByteMatrix byteMatrix = new MultiFormatWriter().encode(InsertContent, BarcodeFormat.QR_CODE, 200, 200);
                    twoDimensionBitmap = ToBitMap(byteMatrix);//原始二维码图片 
                }
                MemoryStream ms = new MemoryStream();
                twoDimensionBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                twoDimensionByte = ms.GetBuffer();
            }
            catch (Exception ex)
            {
                Tellyes.Log4Net.Log4NetUtility.Error("生成二维码", "设备生成二维码信息失败！" + ex.Message);
            }
            return twoDimensionByte;
        }

        /// <summary>
        /// 将Byte矩阵 转化为 位图图片
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static Bitmap ToBitMap(ByteMatrix matrix)
        {
            int width = matrix.Width;
            int height = matrix.Height;
            Bitmap bmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    bmap.SetPixel(x, y, matrix.get_Renamed(x, y) != -1 ? ColorTranslator.FromHtml("0xFF000000") : ColorTranslator.FromHtml("0xFFFFFFFF"));
                }
            }
            return bmap;
        }
    }
}
