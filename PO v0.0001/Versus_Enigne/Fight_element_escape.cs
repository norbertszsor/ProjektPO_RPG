using System;
using System.Threading;

namespace PO_v0._0001
{
    class Fight_element_escape
    {

        public int run_forest_run()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            
            if (dice >= 3)
            {
                Console.Clear();
                Console.WriteLine("Ucieczka zakonczona niepowodzeniem");
                Thread.Sleep(2000);
                return 1;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ucieczka zakonczona sukcesem");
                Thread.Sleep(2000);
                return 0;
            }
        }

       
    }
}
