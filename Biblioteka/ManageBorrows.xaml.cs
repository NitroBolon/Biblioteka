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
    public partial class ManageBorrows : UserControl
    {
        public Wypozyczenie borrow;
        public int indeks;
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
            parentWindow.Title = "Bibliotex - Wypozyczenia";
            borrowList.ItemsSource = parentWindow.borrows;
            book.ItemsSource = parentWindow.books;
            user.ItemsSource = parentWindow.clients;
        }
        public void clearInputs()
        {
            index.Text = "";
            user.Text = "";
            book.Text = "";
        }

        private void save_Borrow(object sender, RoutedEventArgs e)
        {
            try  //zapisać
            {
                MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                TextBox ind = (TextBox)index;
                Uzytkownik uzy = (Uzytkownik)user.SelectedItem;
                Ksiazka ksi = (Ksiazka) book.SelectedItem;

                if (String.IsNullOrEmpty(ind.Text) || String.IsNullOrEmpty(user.Text) || String.IsNullOrEmpty(book.Text))
                {
                    CustomMessageBox.ShowDialog("Pola nie mogą być puste!");
                }
                else
                {
                    Wypozyczenie borrow = new Wypozyczenie(Int32.Parse(ind.Text), uzy, ksi);
                    parentWindow.borrows.Add(borrow);
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
            mod.IsEnabled = true;
            add.IsEnabled = false;
            del.IsEnabled = false;
            index.Text = borrow.indeks.ToString();
            user.SelectedItem = borrow.indeks_uzytkownika;
            book.SelectedItem = borrow.indeks_ksiazki;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CustomMessageBox.ShowDialog("Czy na pewno chcesz skasowac wypożyczenie użytkownika " + borrow.indeks_uzytkownika + " - " + borrow.indeks_ksiazki.tytul + "?", CustomMessageBox.Buttons.Yes_No) == "1")
                {
                    MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                    parentWindow.borrows.RemoveAt(indeks);
                }
            }
            catch (Exception)
            {

            }
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Trace.WriteLine("Select");
            borrow = (Wypozyczenie)borrowList.SelectedItem;
            indeks = (int)borrowList.SelectedIndex;
        }

        private void edit_Client(object sender, RoutedEventArgs e)
        {
            try
            {
                MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                TextBox ind = (TextBox)index;
                Ksiazka ksi = (Ksiazka)book.SelectedItem;
                Uzytkownik uzy = (Uzytkownik)user.SelectedItem;

                if (String.IsNullOrEmpty(ind.Text) || String.IsNullOrEmpty(ksi.tytul) || String.IsNullOrEmpty(uzy.imie))
                {
                    CustomMessageBox.ShowDialog("Pola nie mogą być puste!");
                }
                else
                {
                    Wypozyczenie borrow = new Wypozyczenie(Int32.Parse(ind.Text), uzy, ksi);
                    parentWindow.borrows[indeks] = borrow;
                    clearInputs();
                    CustomMessageBox.ShowDialog("Klient został zedytowany poprawnie!");
                    add.IsEnabled = true;
                    mod.IsEnabled = false;
                }
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Klient nie został zedytowany!");

            }
        }
    }
}
