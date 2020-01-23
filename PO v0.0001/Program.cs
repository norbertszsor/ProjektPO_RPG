using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace PO_v0._0001
{
    class Program
    {
        static void Main(string[] args)
        {





            Map mapa = new Map(30, 15, Versus_Menu.Menu());
            mapa.generuj();

            while (true)
            {

                mapa.show();
                Statystki.show_spec_stat(mapa.bohater.postac);
                mapa.showEvent();
                mapa.ruch();
                
                Console.Clear();
            }


           


       

        }
    }
}
