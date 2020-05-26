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
using System.Windows.Shapes;

namespace Biblioteka
{
    /// <summary>
    /// Logika interakcji dla klasy MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public ObservableCollection<Ksiazka> books { get; set; } = new ObservableCollection<Ksiazka>();
        public ObservableCollection<Uzytkownik> clients { get; set; } = new ObservableCollection<Uzytkownik>();
        public ObservableCollection<Kara> fines { get; set; } = new ObservableCollection<Kara>();
        public ObservableCollection<Wypozyczenie> borrows { get; set; } = new ObservableCollection<Wypozyczenie>();

        public MainMenu()
        {
            InitializeComponent();

            System.IO.StreamReader file = new System.IO.StreamReader("../../data/ksiazki.txt");
            string line;
            string[] tmp;
            while ((line = file.ReadLine()) != null)
            {
                tmp = line.Split('_');
                books.Add(new Ksiazka(Convert.ToInt32(tmp[0]), tmp[1], tmp[2], Convert.ToInt32(tmp[3])));
            }
            file.Close();

            file = new System.IO.StreamReader("../../data/klienci.txt");
            while ((line = file.ReadLine()) != null)
            {
                tmp = line.Split('_');
                clients.Add(new Uzytkownik(Convert.ToInt32(tmp[0]), tmp[1], tmp[2], Convert.ToInt32(tmp[3])));
            }
            file.Close();

            Uzytkownik x = new Uzytkownik();
            Ksiazka y = new Ksiazka();
            file = new System.IO.StreamReader("../../data/wypozyczenia.txt");
            while ((line = file.ReadLine()) != null)
            {
                tmp = line.Split('_');
                for (int i = 0; i < clients.Count; i++)
                    if (clients[i].indeks == Convert.ToInt32(tmp[1])) x = clients[i];
                for (int i = 0; i < books.Count; i++)
                    if (books[i].indeks == Convert.ToInt32(tmp[2])) y = books[i];

                borrows.Add(new Wypozyczenie(Convert.ToInt32(tmp[0]), x, y));
            }
            file.Close();

            Wypozyczenie z = new Wypozyczenie();
            file = new System.IO.StreamReader("../../data/kary.txt");
            while ((line = file.ReadLine()) != null)
            {
                tmp = line.Split('_');
                for (int i = 0; i < borrows.Count; i++)
                    if (borrows[i].indeks == Convert.ToInt32(tmp[0])) z = borrows[i];

                fines.Add(new Kara(z, Convert.ToDateTime(tmp[1]), Convert.ToDateTime(tmp[2]), Convert.ToDouble(tmp[3])));
            }
            file.Close();

            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            this.contentBox.Content = new MainMenuView();
        }

        private void MainMenu_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //obsluga zapisania zmian do pliku itepe itede
            System.IO.StreamWriter file2 = new System.IO.StreamWriter("../../data/ksiazki.txt");
            for (int i = 0; i < books.Count; i++)
                file2.WriteLine(books[i].indeks + "_" + books[i].tytul + "_" + books[i].autor + "_" + books[i].rok_wydania);
            file2.Close();

            file2 = new System.IO.StreamWriter("../../data/klienci.txt");
            for (int i = 0; i < clients.Count; i++)
                file2.WriteLine(clients[i].indeks + "_" + clients[i].imie + "_" + clients[i].nazwisko + "_" + clients[i].telefon);
            file2.Close();

            file2 = new System.IO.StreamWriter("../../data/wypozyczenia.txt");
            for (int i = 0; i < borrows.Count; i++)
                file2.WriteLine(borrows[i].indeks + "_" + borrows[i].indeks_uzytkownika.indeks + "_" + borrows[i].indeks_ksiazki.indeks);
            file2.Close();

            file2 = new System.IO.StreamWriter("../../data/test.txt");
            for (int i = 0; i < borrows.Count; i++)
                file2.WriteLine(fines[i].wypozyczenie.indeks + "_" + fines[i].data_wypozyczenia + "_" + fines[i].data_zwrotu);
            file2.Close();
        }
    }
}
