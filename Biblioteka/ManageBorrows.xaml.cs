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
        MainMenu parentWindow;
        public ManageBorrows()
        {
            InitializeComponent();
        }

        private void wyjdz_Click(object sender, RoutedEventArgs e)
        {
            //MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.contentBox.Content = new MainMenuView();
        }

        private void ManageBorrows_Loaded(object sender, RoutedEventArgs e)
        {
            parentWindow = Window.GetWindow(this) as MainMenu;
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
                //MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                TextBox ind = (TextBox)index;
                Uzytkownik uzy = (Uzytkownik)user.SelectedItem;
                Ksiazka ksi = (Ksiazka)book.SelectedItem;
                bool flag = false;
                for (int i = 0; i < parentWindow.borrows.Count; i++)
                {
                    if (parentWindow.borrows[i].indeks == Int32.Parse(ind.Text)) flag = true;
                }
                if (String.IsNullOrEmpty(ind.Text) || String.IsNullOrEmpty(user.Text) || String.IsNullOrEmpty(book.Text))
                {
                    CustomMessageBox.ShowDialog("Pola nie mogą być puste!");
                }
                else if (flag)
                {
                    CustomMessageBox.ShowDialog("Podane ID już wystąpiło!");
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
            //MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            Wypozyczenie ind1 = (Wypozyczenie)borrowList.SelectedItem;
            int ind = ind1.indeks;
            int x = 0;
            bool flag = false;
            try
            {
                for (int i = 0; i < parentWindow.borrows.Count; i++)
                {
                    if (parentWindow.borrows[i].indeks == Int32.Parse(index.Text)) x++;
                }
                if (x > 1) flag = true;
                if (String.IsNullOrEmpty(index.Text) || String.IsNullOrEmpty(user.Text) || String.IsNullOrEmpty(book.Text))
                {
                    CustomMessageBox.ShowDialog("Pola nie mogą być puste!");
                }
                else if (flag)
                {
                    CustomMessageBox.ShowDialog("Podane ID już wystąpiło!");
                }
                else
                {
                    int f = -1;
                    for (int i = 0; i < parentWindow.borrows.Count; i++)
                    {
                        if (parentWindow.borrows[i].indeks == indeks) f = i;
                    }

                    parentWindow.borrows[f].indeks = Int32.Parse(index.Text);
                    parentWindow.borrows[f].indeks_uzytkownika = (Uzytkownik)user.SelectedItem;
                    parentWindow.borrows[f].indeks_ksiazki = (Ksiazka)book.SelectedItem; 

                    clearInputs();
                    CustomMessageBox.ShowDialog("Klient został zapisany poprawnie!");
                }
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Klient nie został zapisany!");
            }
            parentWindow.contentBox.Content = new ManageBorrows();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            //MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            try
            {
                if (CustomMessageBox.ShowDialog("Czy na pewno chcesz skasowac wypożyczenie użytkownika " + borrow.indeks_uzytkownika + " - " + borrow.indeks_ksiazki.tytul + "?", CustomMessageBox.Buttons.Yes_No) == "1")
                {
                    
                    int f = -1;
                    for (int i = 0; i < parentWindow.borrows.Count; i++)
                    {
                        if (parentWindow.borrows[i].indeks == borrow.indeks) f = i;
                    }
                    parentWindow.borrows.RemoveAt(f);
                }
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Coś poszło nie tak...");
            }
            parentWindow.contentBox.Content = new ManageBorrows();
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            //Trace.WriteLine("Select");
            borrow = (Wypozyczenie)borrowList.SelectedItem;
            
            if (borrowList.SelectedIndex >= 0 && borrowList.SelectedIndex < parentWindow.borrows.Count)
            {
                indeks = borrow.indeks;
                index.Text = parentWindow.borrows[borrowList.SelectedIndex].indeks.ToString();
                user.SelectedItem = parentWindow.borrows[borrowList.SelectedIndex].indeks_uzytkownika;
                book.SelectedItem = parentWindow.borrows[borrowList.SelectedIndex].indeks_ksiazki;
            }

        }
        private void user_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (search_user.Text == "Użytkownik")
            {
                search_user.Text = "";
                search_user.Opacity = 1;
            }
            else
                search_user.Opacity = 1;
        }

        private void user_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            //MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            search_user.Text = "Użytkownik";
            search_user.Opacity = 0.7;
            borrowList.ItemsSource = parentWindow.borrows;
        }

        private void user_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (parentWindow != null)
            {
                var myCollection = parentWindow.borrows;
                var result = myCollection.Where(w => w.indeks_uzytkownika.imie.Contains(search_user.Text));
                borrowList.ItemsSource = result;
            }
        }

        private void book_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (search_book.Text == "Książka")
            {
                search_book.Text = "";
                search_book.Opacity = 1;
            }
            else
                search_book.Opacity = 1;
        }

        private void book_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            //MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            search_book.Text = "Książka";
            search_book.Opacity = 0.7;
            borrowList.ItemsSource = parentWindow.borrows;
        }

        private void book_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (parentWindow != null)
            {
                var myCollection = parentWindow.borrows;
                var result = myCollection.Where(w => w.indeks_ksiazki.tytul.Contains(search_book.Text));
                borrowList.ItemsSource = result;
            }
        }
    }
}
