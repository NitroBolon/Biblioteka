using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Wypozyczenie
    {
        int indeks { get; set; }
        Uzytkownik indeks_uzytkownika { get; set; }
        Ksiazka indeks_ksiazki { get; set; }

        Wypozyczenie() { }
        Wypozyczenie(int id, Uzytkownik id_u, Ksiazka id_k)
        {
            indeks = id;
            indeks_uzytkownika = id_u;
            indeks_ksiazki = id_k;
        }
    }
}
