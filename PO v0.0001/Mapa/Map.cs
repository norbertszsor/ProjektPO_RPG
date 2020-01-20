using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
    public class Map
    {
        public int lenght;
        public int widht;
        public char[,] tmp_mapa;
        public Random rnd = new Random();

        public Map(int lenght, int widht)
        {
            this.lenght = lenght;
            this.widht = widht;
            this.tmp_mapa = new char[this.lenght, this.widht];
        }

        public void generate()
        {
            int ts;



            for (int i = 0; i < this.lenght; i++)
            {
                for (int j = 0; j < this.widht; j++)
                {
                    ts = rnd.Next(1, 7);
                    if (ts == 6)
                    {
                        MapElement tmp_rock = new Rock(i, j);
                        this.tmp_mapa[i, j] = tmp_rock.icon;

                    }
                    else
                    {
                        MapElement tmp_grass = new Grass(i, j);
                        this.tmp_mapa[i, j] = tmp_grass.icon;
                    }



                }
            }

        }
        public void show()
        {
            for (int i = 0; i < this.tmp_mapa.GetLength(0); i++)
            {
                for (int j = 0; j < this.tmp_mapa.GetLength(1); j++)
                {
                    Console.Write(this.tmp_mapa[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
