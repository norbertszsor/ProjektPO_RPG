using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
    class Mapa
    {
            public int height;
            public int widht;
            public char[,] tmp_mapa;
            public Random rnd = new Random();

            public Mapa(int lenght, int widht)
            {
                this.height = lenght;
                this.widht = widht;
                this.tmp_mapa = new char[this.height, this.widht];
                generate();
            }

            public void generate()
            {
                int ts;



                for (int i = 0; i < this.height; i++)
                {
                    for (int j = 0; j < this.widht; j++)
                    {
                        ts = rnd.Next(1, 7);
                        if (ts == 6)
                        {
                            
                            this.tmp_mapa[i, j] = 'O';

                        }
                        else
                        {

                        this.tmp_mapa[i, j] = '.';
                        }



                    }
                }

            }
            public void show()
            {
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < widht; j++)
                    {
                        Console.Write(tmp_mapa[i, j]);
                    }
                    Console.WriteLine();
                }

            }
        }
    }

