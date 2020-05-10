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

namespace Biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy CustomMessageBoxView.xaml
    /// </summary>
    public partial class CustomMessageBoxView : Window
    {
        public string ReturnString { get; set; }

        public CustomMessageBoxView(string Text, CustomMessageBox.Buttons buttons)
        {
            InitializeComponent();
            wiadomosc.Text = Text;

            switch (buttons)
            {
                case CustomMessageBox.Buttons.OK:
                    ok.Visibility = Visibility.Visible;
                    break;
                case CustomMessageBox.Buttons.Yes_No:
                    tak.Visibility = Visibility.Visible;
                    nie.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void gBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                DragMove();
            }
            catch
            {

            }
        }

        private void zamknij_Click(object sender, RoutedEventArgs e)
        {
            ReturnString = "-1";
            Close();
        }

        private void ReturnValue_Click(object sender, RoutedEventArgs e)
        {
            ReturnString = ((Button)sender).Uid.ToString();
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Height = (wiadomosc.LineCount * 33) + gBar.Height + 60;
        }
    }
}
