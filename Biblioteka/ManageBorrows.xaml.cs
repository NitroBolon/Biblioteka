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

namespace Biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy ManageBorrows.xaml
    /// </summary>
    public partial class ManageBorrows : UserControl
    {
        public ManageBorrows()
        {
            InitializeComponent();
        }

        private void wyjdz_Click(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.contentBox.Content = new MainMenuView();
        }

        private void ManageBorrows_Loaded(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.Title = "Bibliotex - Wypożyczenia";
        }

        private void SUserTextBox_Clearing(object sender, MouseButtonEventArgs e)
        {
            search_user.Text="";
        }
        private void SBookTextBox_Clearing(object sender, MouseButtonEventArgs e)
        {
            search_book.Text="";
        }
    }
}
