using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    class Kara
    {
        Wypozyczenie wypozyczenie { get; set; }
        DateTime data_wypozyczenia { get; set; }
        DateTime data_zwrotu { get; set; }
        float kara { get; set; }

        Kara() { }
        Kara(Wypozyczenie wyp, DateTime d_wyp, DateTime d_zwr, float kar) 
        {
            wypozyczenie = wyp;
            data_wypozyczenia = d_wyp;
            data_zwrotu = d_zwr;
            kara = kar;
        }
    }
}
