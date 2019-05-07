using System.Windows;
using System.Windows.Media;

namespace 拾色器
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        MainClass mainObj = new MainClass();
        public MainWindow()
        {
            InitializeComponent();
        }

        //记录btn
        private void BtnRecord_Click(object sender, RoutedEventArgs e)
        {
            Function.Record(this);
        }

        //复制btn
        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            Function.Copy(this);
        }

        //拾色btn
        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            LeyoutProcess.UpdataTextBox(this);
            Void window = new Void();//打开截屏
            window.ShowDialog();
            txtbokColorMaster.Background = new SolidColorBrush(Data.Color);//传颜色
            txtboxHexColorMaster.Text = Data.Red.ToString("X2") + Data.Green.ToString("X2") + Data.Blue.ToString("X2");//传颜色代码

            if (checkAutoCopy.IsChecked == true)
            {
                Function.Copy(this);
            }
            if (checkAutoRecord.IsChecked == true)
            {
                txtboxShow.AppendText("#"+txtboxHexColorMaster.Text+"\n");
            }
        }

        //清除btn
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            if (txtboxShow.Text != "")
            {
                txtboxShow.Text = "";
            }
            else
            {
                Function.txtToNULL(this);
            }
        }

        //自动记录CheckBox点击事件
        private void CheckAutoRecord_Click(object sender, RoutedEventArgs e)
        {
            if (checkAutoRecord.IsChecked == true)
            {
                checkOne.IsEnabled = false;
                checkTwo.IsEnabled = false;
                checkThree.IsEnabled = false;
                checkFour.IsEnabled = false;
                checkFives.IsEnabled = false;
                checkNew.IsEnabled = false;
            }
            else
            {
                checkOne.IsEnabled = true;
                checkTwo.IsEnabled = true;
                checkThree.IsEnabled = true;
                checkFour.IsEnabled = true;
                checkFives.IsEnabled = true;
                checkNew.IsEnabled = true;
            }
        }
    }
}
/*
 * MianClass主要是鼠标坐标转Color
 * AidClass主要是截屏传给Void.xaml
 * LeyoutProcess主要是更改控件参数
 * Data存放些公共参数
 * Function放一些MainWindow的函数
 * 
 * 本人只是个学生，只学了两年的C#，没有开发经验，
 * 代码有点乱
 * 这是我第一个开源项目*/
