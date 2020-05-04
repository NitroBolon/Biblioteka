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
    /// Logika interakcji dla klasy ManageFines.xaml
    /// </summary>
    public partial class ManageFines : UserControl
    {
        public ManageFines()
        {
            InitializeComponent();
        }

        private void wyjdz_Click(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.contentBox.Content = new MainMenuView();
        }

        private void ManageFines_Loaded(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.Title = "Bibliotex - Kary";
        }
    }
}
