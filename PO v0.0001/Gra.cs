using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
    class Gra
    {
        //klasa której metody wywołujemy żeby nie zaśmiecać Main'a
        Map Mapa = new Map(5, 6);
        public void Generuj()
        {
            Mapa.generuj();
        }
        public void Wyswietl()
        {
            Mapa.show();
        }

    }
}
