using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
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
        public Kara kara;
        public int index;

        public ManageFines()
        {
            InitializeComponent();
        }

        private void wyjdz_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CustomMessageBox.ShowDialog("Czy na pewno chcesz wyjść ?", CustomMessageBox.Buttons.Yes_No) == "1")
                {
                    MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                    parentWindow.contentBox.Content = new MainMenuView();
                }
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Element nie został zapisany!");
            }

        }

        private void ManageFines_Loaded(object sender, RoutedEventArgs e)
        {
            MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
            parentWindow.Title = "Bibliotex - Kary";
            listView.ItemsSource = parentWindow.fines;

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(listView.ItemsSource);
            view.Filter = FineFilter;

            borrowComboBox.ItemsSource = parentWindow.borrows;
            borrowComboBox.DisplayMemberPath = "indeks";

            indexFilter.Text = "Indeks";
            indexFilter.Opacity = 0.7;
        }

        private void zapisz_Click(object sender, RoutedEventArgs e)
        {
            double fine;
            bool exists = false;
            Wypozyczenie w;
            try  //zapisać
            {
                MainMenu parentWindow = Window.GetWindow(this) as MainMenu;

                foreach(Kara k in parentWindow.fines)
                {
                    w = (Wypozyczenie)borrowComboBox.SelectedItem;
                    if (w.indeks == k.wypozyczenie.indeks)
                        exists = true;
                }

                if (String.IsNullOrEmpty(fineTextBox.Text) || borrowComboBox.SelectedItem == null || borrowDatePicker.SelectedDate.Value == null || returnDatePicker.SelectedDate.Value == null)
                {
                    CustomMessageBox.ShowDialog("Pola nie mogą być puste!");
                }
                else if(!Double.TryParse(fineTextBox.Text, out fine))
                {
                    CustomMessageBox.ShowDialog("Wartość kary nie jest liczbą!");
                }
                else if (exists)
                {
                    CustomMessageBox.ShowDialog("Kara dla wybranego wypożyczenia już istnieje!");
                }
                else
                {
                    Kara tmp = new Kara((Wypozyczenie)borrowComboBox.SelectedItem, borrowDatePicker.SelectedDate.Value, returnDatePicker.SelectedDate.Value, Convert.ToDouble(fineTextBox.Text));
                    parentWindow.fines.Add(tmp);
                    clearInputs();
                    CustomMessageBox.ShowDialog("Kara zapisana poprawnie!");
                }
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Kara nie została zapisana!");
            }
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CustomMessageBox.ShowDialog("Czy na pewno chcesz usunąć karę " + kara.wypozyczenie.indeks + "?", CustomMessageBox.Buttons.Yes_No) == "1")
                {
                    MainMenu parentWindow = Window.GetWindow(this) as MainMenu;
                    parentWindow.fines.Remove(kara);
                }
            }
            catch (Exception)
            {
                CustomMessageBox.ShowDialog("Kara nie została usunięta!");
            }
        }

        public void clearInputs()
        {
            borrowComboBox.SelectedItem = null;
            borrowDatePicker.SelectedDate = null;
            returnDatePicker.SelectedDate = null;
            fineTextBox.Text = "";
        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Trace.WriteLine("Select");
            kara = (Kara)listView.SelectedItem;
        }

        private bool FineFilter(Object item)
        {
            if (String.IsNullOrEmpty(indexFilter.Text) || !Int32.TryParse(indexFilter.Text, out int id))
                return true;
            else
                return (item as Kara).wypozyczenie.indeks.ToString().IndexOf(indexFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void indexFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(listView.ItemsSource).Refresh();
        }

        private void indexFilter_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            indexFilter.Text = "";
            indexFilter.Opacity = 1;
        }

        private void indexFilter_LostKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            indexFilter.Text = "Indeks";
            indexFilter.Opacity = 0.7;
        }
    }
}
