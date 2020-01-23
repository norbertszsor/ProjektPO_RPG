using System;
using System.Threading;

namespace PO_v0._0001
{
    static class Versus_escape
    {

        public static int run_try()
        {
            Random rnd = new Random();
            int dice = rnd.Next(1, 7);
            
            if (dice == 3)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

       
    }
}
