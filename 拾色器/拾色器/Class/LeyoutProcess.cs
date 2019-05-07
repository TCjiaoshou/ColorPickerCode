using System.Windows.Controls;
namespace 拾色器
{
    class LeyoutProcess
    {
        public static void UpdataTextBox(MainWindow obj)
        {
            UpdataTxtFun(obj.txtbokColorFour, obj.txtboxHexColorFour, obj.txtbokColorFives, obj.txtboxHexColorFives);
            UpdataTxtFun(obj.txtbokColorThree, obj.txtboxHexColorThree, obj.txtbokColorFour, obj.txtboxHexColorFour);
            UpdataTxtFun(obj.txtbokColorTwo, obj.txtboxHexColorTwo, obj.txtbokColorThree, obj.txtboxHexColorThree);
            UpdataTxtFun(obj.txtbokColorOne, obj.txtboxHexColorOne, obj.txtbokColorTwo, obj.txtboxHexColorTwo);
            UpdataTxtFun(obj.txtbokColorMaster, obj.txtboxHexColorMaster, obj.txtbokColorOne, obj.txtboxHexColorOne);
        }

        private static void UpdataTxtFun(TextBlock bok1, TextBox box1, TextBlock bok2, TextBox box2 )
        {
            if (box1.Text != "")
            {
                bok2.Background = bok1.Background;
                box2.Text = box1.Text;
            }
        }

    }
}
