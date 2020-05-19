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

            lista.ItemsSource = parentWindow.books;
        }

        private void zapisz_Click(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;

            int ind;
            bool isConv1 = Int32.TryParse(id.Text, out ind);
            String tit = title.Text;
            String auth = author.Text;
            int yr;
            bool isConv = Int32.TryParse(year.Text, out yr);

            if (isConv == true && isConv1 == true)
            {
                parentWindow.books.Add(new Ksiazka(ind, tit, auth, yr));
                CustomMessageBox.ShowDialog("Książka zapisana poprawnie!");
            }
            else CustomMessageBox.ShowDialog("Książka nie została zapisana!");

        }
    }
}
