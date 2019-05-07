using System.Windows;
using System.Windows.Media;

namespace 拾色器
{
    static class Function
    {
        public static void txtToNULL(MainWindow obj)
        {
            obj.txtboxHexColorOne.Text = "";
            obj.txtboxHexColorTwo.Text = "";
            obj.txtboxHexColorThree.Text = "";
            obj.txtboxHexColorFour.Text = "";
            obj.txtboxHexColorFives.Text = "";

            obj.txtbokColorOne.Background = Brushes.White;
            obj.txtbokColorTwo.Background = Brushes.White;
            obj.txtbokColorThree.Background = Brushes.White;
            obj.txtbokColorFour.Background = Brushes.White;
            obj.txtbokColorFives.Background = Brushes.White;
        }

        public static void Copy(MainWindow obj)
        {
            if (obj.txtboxHexColorMaster.Text != "")
            {
                Clipboard.SetDataObject(obj.txtboxHexColorMaster.Text);
            }
        }

        public static void Record(MainWindow obj)
        {
            Data.Count++;
            string str=Data.Count.ToString()+":\n";
            if (obj.checkFives.IsChecked == true && obj.txtboxHexColorFives.Text!="")
            {
                str += "#"+obj.txtboxHexColorFives.Text + "\n";
            }
            if (obj.checkFour.IsChecked == true && obj.txtboxHexColorFour.Text != "")
            {
                str += "#"+obj.txtboxHexColorFour.Text + "\n";
            }
            if (obj.checkThree.IsChecked == true && obj.txtboxHexColorThree.Text != "")
            {
                str += "#"+obj.txtboxHexColorThree.Text + "\n";
            }
            if (obj.checkTwo.IsChecked == true && obj.txtboxHexColorTwo.Text != "")
            {
                str += "#"+obj.txtboxHexColorTwo.Text + "\n";
            }
            if (obj.checkOne.IsChecked == true && obj.txtboxHexColorOne.Text != "")
            {
                str += "#"+obj.txtboxHexColorOne.Text + "\n";
            }
            if (obj.checkNew.IsChecked == true && obj.txtboxHexColorMaster.Text != "")
            {
                str += "#"+obj.txtboxHexColorMaster.Text + "\n";
            }

            obj.txtboxShow.AppendText(str);

        }
    }
}
