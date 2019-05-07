using System;
using System.Runtime.InteropServices;
using System.Windows.Media;

namespace 拾色器精简
{
    class MainClass
    {
        #region 像素位置转颜色
        private struct POINT
        {
            private int x;
            private int y;
        }

        static POINT point;

        [DllImport("user32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetDC(int hwnd);
        [DllImport("gdi32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int GetPixel(int hdc, int x, int y);
        [DllImport("user32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int ReleaseDC(int hwnd, int hdc);
        [DllImport("user32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int WindowFromPoint(int x, int y);
        [DllImport("user32", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int ScreenToClient(int hwnd, ref POINT lppoint);

        //获取屏幕指定坐标点的颜色
        public Color GetPixelColor(int x, int y, ref int r, ref int g, ref int b)
        {
            int h = WindowFromPoint(x, y);
            int hdc = GetDC(h);

            ScreenToClient(h, ref point);
            int c = GetPixel(hdc, x, y);
            r = c % 256;
            g = (c / 256) % 256;
            b = c / 256 / 256;
            Color color = Color.FromArgb(0xFF, Convert.ToByte(r), Convert.ToByte(g), Convert.ToByte(b));
            return color;
        }
        #endregion

        #region 获取鼠标坐标
        /// <summary>   
                /// 设置鼠标的坐标   
                /// </summary>   
                /// <param name="x">横坐标</param>   
                /// <param name="y">纵坐标</param>          

        //[DllImport("User32")]

        //public extern static void SetCursorPos(int x, int y);
        public struct POIN
        {
            public int X;
            public int Y;
            public POIN(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }
        }

        /// <summary>   
        /// 获取鼠标的坐标   
        /// </summary>   
        /// <param name="lpPoint">传址参数，坐标point类型</param>   
        /// <returns>获取成功返回真</returns>   

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool GetCursorPos(out POIN pt);

        public void GetMove(ref int x, ref int y)
        {
            POIN p = new POIN();
            if (GetCursorPos(out p))//API方法
            {
                x = p.X;
                y = p.Y;
            }
        }
    }
    #endregion
}


