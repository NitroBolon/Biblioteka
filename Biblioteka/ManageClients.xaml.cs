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
    /// Logika interakcji dla klasy ManageClients.xaml
    /// </summary>
    public partial class ManageClients : UserControl
    {
        public ManageClients()
        {
            InitializeComponent();

        }

        private void wyjdz_Click(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.contentBox.Content = new MainMenuView();
        }

        private void ManageClients_Loaded(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.Title = "Bibliotex - Klienci";
        }

        private void zapisz_Click(object sender, RoutedEventArgs e)
        {
            try  //zapisać
            {
                CustomMessageBox.ShowDialog("Klient został zapisany poprawnie!");
                //CustomMessageBox.ShowDialog("Element zapisany poprawnie!");
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Klient nie został zapisany!");
                throw;
            }
        }
    }
}
