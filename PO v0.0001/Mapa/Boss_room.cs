using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
    class Boss_room:Level
    {
        public MapElement[,] mapa_Elementy;

        public void generuj()
        {
            this.mapa_Elementy = new MapElement[3, 10];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || j == 0 || i == 2 || j == 9)
                    {
                        mapa_Elementy[i, j] = new Rock(i, j);
                    }
                    else
                    {
                        mapa_Elementy[i, j] = new Grass(i, j);
                    }
                }
            }
            mapa_Elementy[1, 8] = new Exit(1, 8);

        }
    }
}
