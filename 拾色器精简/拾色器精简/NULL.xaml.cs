using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace 拾色器精简
{
    /// <summary>
    /// NULL.xaml 的交互逻辑
    /// </summary>
    public partial class NULL : Window
    {
        AidClass Aid = new AidClass();
        MainClass mainClass = new MainClass();

        int x = 0;
        int y = 0;

        public NULL()
        {
            InitializeComponent();
            img.Source = Aid.GetScreenSnapshot();
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            mainClass.GetMove(ref x, ref y);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            int r, g, b; r = g = b = 0;
            Data.Color = mainClass.GetPixelColor(x, y, ref r, ref g, ref b);

            Data.Red = r;
            Data.Green = g;
            Data.Blue = b;

            this.Close();
        }
    }
}
