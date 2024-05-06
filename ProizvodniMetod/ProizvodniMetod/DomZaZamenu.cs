using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodniMetod
{
    internal class DomZaZamenu
    {
        public string Lokacija { get; set; }
        public int Velicina { get; set; }
        public int BrojSoba { get; set; }
        public int Opremljenost { get; set; }

        public DomZaZamenu(string lokacija, int velicina, int brojSoba, int opremljenost)
        {
            Lokacija = lokacija;
            Velicina = velicina;
            BrojSoba = brojSoba;
            Opremljenost = opremljenost;
        }
    }
}
