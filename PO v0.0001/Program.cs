using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{

    class Program
    {
        static void Main(string[] args)
        {

            Map mapa = new Map(30, 20);
            mapa.generuj();
            
            while (true)
            {
                
                mapa.show();
                mapa.ruch();
                Console.Clear();
            }

            Console.ReadKey();
          
        }
    }
}
