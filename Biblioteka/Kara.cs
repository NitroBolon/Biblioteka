using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteka
{
    public class Kara
    {
        public Wypozyczenie wypozyczenie { get; set; }
        public DateTime data_wypozyczenia { get; set; }
        public DateTime data_zwrotu { get; set; }
        public double kara { get; set; }

        public Kara() { }
        public Kara(Wypozyczenie wyp, DateTime d_wyp, DateTime d_zwr, double kar) 
        {
            wypozyczenie = wyp;
            data_wypozyczenia = d_wyp;
            data_zwrotu = d_zwr;
            kara = kar;
        }
    }
}
