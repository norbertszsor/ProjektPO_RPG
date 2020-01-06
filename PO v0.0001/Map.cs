using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
    public class Map
    {
        public Player bohater = new Player(0, 0);
        public int width;
        public int height;
        public MapElement[,] mapa_Elementy;
        public Random rnd = new Random();

        public Map(int lenght, int widht)
        {
            this.width = lenght;
            this.height = widht;
            mapa_Elementy = new MapElement[lenght, widht];
        }

        public void generate()
        {
            Console.Write("Generowanie mapy Prosze Czekać");
            //Zapełniam Mape 
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.height; j++)
                {
                   mapa_Elementy[i, j] = new Grass(i, j);
                }
            }
            //tworze nodey
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.height; j++)
                {
                    var random = rnd.Next(1, 8);
                    if (!Zwroc_Sasiadow(mapa_Elementy[i,j]).Exists(e=>e is Node_Generatora))
                    {
                        
                        foreach (var item in Zwroc_Sasiadow(mapa_Elementy[i,j]))
                        {
                            if (!Zwroc_Sasiadow(item).Exists(e => e is Node_Generatora) && random == 1)
                            {
                                mapa_Elementy[i, j] = new Node_Generatora(i, j);
                            }
                        }
                    }
                }
            }
            //zamiana nodow na skały
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.height; j++)
                {
                    if (mapa_Elementy[i,j] is Node_Generatora)
                    {
                        try { mapa_Elementy[i + 1, j] = new Rock(i + 1, j);  } catch (IndexOutOfRangeException) { }
                        try { mapa_Elementy[i + 1, j + 1] = new Rock(i + 1, j + 1);  } catch (IndexOutOfRangeException) { }
                        try { mapa_Elementy[i, j + 1] = new Rock(i, j + 1);  } catch (IndexOutOfRangeException) { }
                        try { mapa_Elementy[i, j] = new Rock(i, j);  } catch (IndexOutOfRangeException) { }
                    }
                }
            }
            //generowanie gracza i wyjscia
            bohater.x = rnd.Next(0, width / 2);
            bohater.y = rnd.Next(0, height);
            var a= rnd.Next(width / 2, width);
            var b=rnd.Next(0, height);
            mapa_Elementy[a,b]=new Exit(a,b);
           
            foreach (var item in Zwroc_Sasiadow(mapa_Elementy[a, b]))
            {
                mapa_Elementy[item.x, item.y] = new Grass(item.x, item.y);
            }
            foreach (var item in Zwroc_Sasiadow(mapa_Elementy[bohater.x, bohater.y]))
            {
                mapa_Elementy[item.x, item.y] = new Grass(item.x, item.y);
            }
            Console.Clear();
        }

        public List<MapElement> Zwroc_Sasiadow(MapElement n)
        {
            var x = n.x;
            var y = n.y;
            List < MapElement > lista= new List<MapElement>();
            try {lista.Add(mapa_Elementy[x - 1, y - 1]);}catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x, y - 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x + 1, y - 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x + 1, y]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x + 1, y + 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x, y + 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x - 1, y + 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x - 1, y]); } catch (IndexOutOfRangeException) { }
            return lista;

        }





















        public void show()
        {
            if (mapa_Elementy[bohater.x, bohater.y] is Exit)
            {
                generate();
                
            }

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i==bohater.y&&j==bohater.x)
                    {
                        Console.Write("☻");
                    }
                    else
                    {
                        Console.Write(mapa_Elementy[j, i].icon);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
