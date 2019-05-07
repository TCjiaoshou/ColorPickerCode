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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;

namespace 拾色器精简
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen; //窗口居中
            this.Topmost = true;
        }

        //拖动窗口
        private void Image_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                try
                {
                    this.DragMove();
                }
                catch { }
            }
        }

        //关闭窗口
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //最小化窗口
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //拾色
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NULL window = new NULL();
            window.ShowDialog();//跳转

            txtColor.Background = new SolidColorBrush(Data.Color);//显示颜色

            string str = Data.Red.ToString("X2") + Data.Green.ToString("X2") + Data.Blue.ToString("X2");//组合数据

            txtColorHex.Text = str;//显示数据

            Clipboard.SetDataObject(str);//加入剪贴板
        }
    }
}
