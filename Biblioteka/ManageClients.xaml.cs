using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
        public Uzytkownik user;
        public int index;
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
        public void clearInputs()
        {
            indexInput.Text = "";
            nameInput.Text = "";
            surnameInput.Text = "";
            phoneInput.Text = "";
        }

        private void save_Client(object sender, RoutedEventArgs e)
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
                    clearInputs();
                    CustomMessageBox.ShowDialog("Klient został zapisany poprawnie!");
                }
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Klient nie został zapisany!");
            }
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            editButton.IsEnabled = true;
            saveButton.IsEnabled = false;
            indexInput.Text = user.indeks.ToString();
            nameInput.Text = user.imie;
            surnameInput.Text = user.nazwisko;
            phoneInput.Text = user.telefon.ToString();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CustomMessageBox.ShowDialog("Czy na pewno chcesz skasowac klienta "+user.imie+" "+user.nazwisko+"?", CustomMessageBox.Buttons.Yes_No) == "1")
                {
                    MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                    parentWindow.clients.RemoveAt(index);
                }
            }
            catch (Exception)
            {

            }
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Trace.WriteLine("Select");
            user = (Uzytkownik)listView.SelectedItem;
            index = (int)listView.SelectedIndex;
        }

        private void edit_Client(object sender, RoutedEventArgs e)
        {
            try  
            {
                MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                TextBox ind = (TextBox)indexInput;
                TextBox name = (TextBox)nameInput;
                TextBox surname = (TextBox)surnameInput;
                TextBox phone = (TextBox)phoneInput;

                if (String.IsNullOrEmpty(ind.Text) || String.IsNullOrEmpty(name.Text) || String.IsNullOrEmpty(surname.Text) || String.IsNullOrEmpty(phone.Text))
                {
                    CustomMessageBox.ShowDialog("Pola nie mogą być puste!");
                }
                else
                {
                    Uzytkownik user = new Uzytkownik(Int32.Parse(ind.Text), name.Text, surname.Text, Int32.Parse(phone.Text));
                    parentWindow.clients[index] = user;
                    clearInputs();
                    CustomMessageBox.ShowDialog("Klient został zedytowany poprawnie!");
                    saveButton.IsEnabled = true;
                    editButton.IsEnabled = false;
                }
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Klient nie został zedytowany!");

            }
        }
    }
}
