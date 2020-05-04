using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Uzytkownik
    {
        int indeks { get; set; }
        String imie { get; set; }
        String nazwisko { get; set; }
        int telefon { get; set; }

        Uzytkownik()
        {
        }
        Uzytkownik(int id, String imi, String naz, int tel)
        {
            indeks = id;
            imie = imi;
            nazwisko = naz;
            telefon = tel;
        }
    }
}
