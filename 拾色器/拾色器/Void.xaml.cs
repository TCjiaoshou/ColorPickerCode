using System.Windows;
using System.Windows.Input;


namespace 拾色器
{
    /// <summary>
    /// Void.xaml 的交互逻辑
    /// </summary>
    public partial class Void : Window
    {
        AidClass Aid = new AidClass();//获取截屏的功能类
        MainClass mainClass = new MainClass();//像素颜色转换的功能类
        

        int X = 0;
        int Y = 0;

        public Void()
        {
            InitializeComponent();
            x.Source = Aid.GetScreenSnapshot();//获取截屏
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int r, g, b; r = g = b = 0;
            //将某个像素的颜色提取出来
            Data.Color = mainClass.GetPixelColor(X, Y,ref r,ref g,ref b);

            Data.Red = r;
            Data.Green = g;
            Data.Blue = b;
            this.Close();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            mainClass.GetMove(ref X, ref Y);
        }
    }

}
