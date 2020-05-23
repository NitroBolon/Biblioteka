using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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
    /// Logika interakcji dla klasy ManageBooks.xaml
    /// </summary>
    public partial class ManageBooks : UserControl
    {
        public Ksiazka book;
        public int index;
        public ManageBooks()
        {
            InitializeComponent();
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
        }

        private void wyjdz_Click(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.contentBox.Content = new MainMenuView();
        }

        private void ManageBooks_Loaded(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.Title = "Bibliotex - Katalog";

            listView.ItemsSource = parentWindow.books;
        }
        public void clearInputs()
        {
            idInput.Text = "";
            authorInput.Text = "";
            yearInput.Text = "";
            titleInput.Text = "";
        }
        private void save_Book(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;

            int ind;
            bool isConv1 = Int32.TryParse(idInput.Text, out ind);
            String tit = titleInput.Text;
            String auth = authorInput.Text;
            int yr;
            bool isConv = Int32.TryParse(yearInput.Text, out yr);

            if (isConv == true && isConv1 == true)
            {
                parentWindow.books.Add(new Ksiazka(ind, tit, auth, yr));
                clearInputs();
                CustomMessageBox.ShowDialog("Książka zapisana poprawnie!");
            }
            else CustomMessageBox.ShowDialog("Książka nie została zapisana!");

        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            editButton.IsEnabled = true;
            saveButton.IsEnabled = false;
            idInput.Text = book.indeks.ToString();
            authorInput.Text = book.autor;
            yearInput.Text = book.rok_wydania.ToString();
            titleInput.Text = book.tytul;
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CustomMessageBox.ShowDialog("Czy na pewno chcesz skasowac książkę " + book.tytul + "?", CustomMessageBox.Buttons.Yes_No) == "1")
                {
                    MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                    parentWindow.books.RemoveAt(index);
                }
            }
            catch (Exception)
            {

            }
        }

        private void edit_Book(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            int ind;
            bool isConv1 = Int32.TryParse(idInput.Text, out ind);
            String tit = titleInput.Text;
            String auth = authorInput.Text;
            int yr;
            bool isConv = Int32.TryParse(yearInput.Text, out yr);

            if (isConv == true && isConv1 == true)
            {
                Ksiazka tmpBook = new Ksiazka(ind,tit,auth,yr);
                parentWindow.books[index] = tmpBook;
                saveButton.IsEnabled = true;
                editButton.IsEnabled = false;
                clearInputs();
                CustomMessageBox.ShowDialog("Książka zedytowana poprawnie!");
            }
            else CustomMessageBox.ShowDialog("Książka nie została zedytowana!");

        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            book = (Ksiazka)listView.SelectedItem;
            index = (int)listView.SelectedIndex;
        }
    }
}
