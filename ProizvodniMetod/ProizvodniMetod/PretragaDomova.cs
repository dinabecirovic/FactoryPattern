using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProizvodniMetod
{
    internal class PretragaDomova
    {
        // Proizvodni metod - pretrazuje domove na osnovu kriterijuma
        public static List<DomZaZamenu> PretraziDomove(List<DomZaZamenu> sviDomovi, string lokacija, int minVelicina, int minBrojSoba, int opremljenost)
        {
            return sviDomovi.Where(dom => dom.Lokacija == lokacija
                                        && dom.Velicina >= minVelicina
                                        && dom.BrojSoba >= minBrojSoba
                                        && dom.Opremljenost >= opremljenost)
                            .ToList();
        }
    }
}
