using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media.Imaging;

namespace 拾色器精简
{
    class AidClass
    {
        #region 截屏

        //*****************获取截屏********************************//
        public BitmapSource GetScreenSnapshot()
        {

            try
            {
                System.Drawing.Rectangle rc = SystemInformation.VirtualScreen;
                var bitmap = new Bitmap(rc.Width, rc.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                using (Graphics memoryGrahics = Graphics.FromImage(bitmap))
                {
                    memoryGrahics.CopyFromScreen(rc.X, rc.Y, 0, 0, rc.Size, CopyPixelOperation.SourceCopy);
                }

                return BitmapToBitmapSource(bitmap);
            }

            catch (Exception)
            {

            }
            return null;
        }


        //*************将form数据bitmap转换成bitmapsource*********************//
        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern bool DeleteObject(IntPtr hObject);

        private BitmapSource BitmapToBitmapSource(System.Drawing.Bitmap bitmap)
        {
            IntPtr ptr = bitmap.GetHbitmap();
            BitmapSource result =
                System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                    ptr, IntPtr.Zero, Int32Rect.Empty, BitmapSizeOptions.FromEmptyOptions());
            //release resource
            DeleteObject(ptr);

            return result;
        }
    }
    #endregion
}
