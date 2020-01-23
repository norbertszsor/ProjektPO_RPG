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

            /*Map mapa = new Map(30, 20, new Rouge("Kuba"));
            mapa.generuj();

            while (true)
            {

                mapa.show();
                Statystki.show_stat(mapa.bohater.postac);
                Statystki.show_spec_stat(mapa.bohater.postac);
                mapa.ruch();
                
                Console.Clear();
            }*/


            Versus_Menu.Menu();


            Console.ReadKey();

        }
    }
}
