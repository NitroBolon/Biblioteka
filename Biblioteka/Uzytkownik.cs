using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Uzytkownik
    {
        public int indeks { get; set; }
        public String imie { get; set; }
        public String nazwisko { get; set; }
        public int telefon { get; set; }

        Uzytkownik()
        {
        }
        public Uzytkownik(int id, String imi, String naz, int tel)
        {
            indeks = id;
            imie = imi;
            nazwisko = naz;
            telefon = tel;
        }
    }
}
