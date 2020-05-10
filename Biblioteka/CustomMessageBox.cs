using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class CustomMessageBox
    {
        public enum Buttons { Yes_No, OK}

        public static string Show(string Text)
        {
            return Show(Text, Buttons.OK);
        }

        public static string Show(string Text, Buttons buttons)
        {
            CustomMessageBoxView messageBoxView = new CustomMessageBoxView(Text, buttons);
            messageBoxView.Show();
            return messageBoxView.ReturnString;
        }

        public static string ShowDialog(string Text)
        {
            return ShowDialog(Text, Buttons.OK);
        }

        public static string ShowDialog(string Text, Buttons buttons)
        {
            CustomMessageBoxView messageBoxView = new CustomMessageBoxView(Text, buttons);
            messageBoxView.ShowDialog();
            return messageBoxView.ReturnString;
        }
    }
}
