using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Ksiazka
    {
        public int indeks { get; set; }
        public String tytul { get; set; }
        public String autor { get; set; }
        public int rok_wydania { get; set; }

        public Ksiazka() { }

        public Ksiazka(int id, String tit, String aut, int rok) 
        {
            indeks = id;
            tytul = tit;
            autor = aut;
            rok_wydania = rok;
        }
    }
}
