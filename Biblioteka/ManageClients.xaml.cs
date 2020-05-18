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
        ObservableCollection<Uzytkownik> list = new ObservableCollection<Uzytkownik>();
        public ManageClients()
        {
            InitializeComponent();
            Uzytkownik u = new Uzytkownik(104085,"Kacper","Makarewicz",123456789);
            list.Add(u);
            listView.ItemsSource = list;
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
                    list.Add(user);
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
