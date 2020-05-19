using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            listView.ItemsSource = parentWindow.clients;
        }

        private void zapisz_Click(object sender, RoutedEventArgs e)
        {
            try  //zapisać
            {
                MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                TextBox ind = (TextBox)indexInput;
                TextBox name = (TextBox)nameInput;
                TextBox surname = (TextBox)surnameInput;
                TextBox phone = (TextBox)phoneInput;
                if(String.IsNullOrEmpty(ind.Text) || String.IsNullOrEmpty(name.Text) || String.IsNullOrEmpty(surname.Text) || String.IsNullOrEmpty(phone.Text))
                {
                    CustomMessageBox.ShowDialog("Pola nie mogą być puste!");
                }
                else
                {
                    Uzytkownik user = new Uzytkownik(Int32.Parse(ind.Text), name.Text, surname.Text, Int32.Parse(phone.Text));
                    parentWindow.clients.Add(user);
                    CustomMessageBox.ShowDialog("Klient został zapisany poprawnie!");
                }
                
                
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Klient nie został zapisany!");

            }
        }
    }
}
