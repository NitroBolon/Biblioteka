using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Ksiazka
    {
        int indeks { get; set; }
        String tytul { get; set; }
        String autor { get; set; }
        int rok_wydania { get; set; }

        Ksiazka() { }

        Ksiazka(int id, String tit, String aut, int rok) 
        {
            indeks = id;
            tytul = tit;
            autor = aut;
            rok_wydania = rok;
        }
    }
}
