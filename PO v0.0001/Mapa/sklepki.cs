using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
    class sklepki:Level
    {
        //klasa do generowania poziomu sklepu
        public MapElement[,] mapa_Elementy;

        public void generuj()
        {
            this.mapa_Elementy = new MapElement[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || j == 0 || i == 9 || j == 9)
                    {
                        mapa_Elementy[i, j] = new Rock(i, j);
                    }
                    else
                    {
                        mapa_Elementy[i, j] = new Grass(i, j);
                    }
                }
            }
            mapa_Elementy[8, 8] = new Exit(8, 8);
            mapa_Elementy[5,5] = new NPC(5, 5);

        }
    }
}
