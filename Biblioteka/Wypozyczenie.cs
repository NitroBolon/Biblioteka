using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Wypozyczenie
    {
        public int indeks { get; set; }
        public Uzytkownik indeks_uzytkownika { get; set; }
        public Ksiazka indeks_ksiazki { get; set; }

        public Wypozyczenie() { }
        public Wypozyczenie(int id, Uzytkownik id_u, Ksiazka id_k)
        {
            indeks = id;
            indeks_uzytkownika = id_u;
            indeks_ksiazki = id_k;
        }
    }
}
