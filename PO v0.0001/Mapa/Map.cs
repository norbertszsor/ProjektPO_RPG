using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace PO_v0._0001
{
    public class Map
    {
<<<<<<< Updated upstream
        public int lenght;
        public int widht;
        public char[,] tmp_mapa;
=======
        public Player bohater;
        public int width;
        public int poziom = 0;
        public int height;
        public MapElement[,] mapa_Elementy;
>>>>>>> Stashed changes
        public Random rnd = new Random();

        public Map(int lenght, int widht,Character c)
        {
<<<<<<< Updated upstream
            this.lenght = lenght;
            this.widht = widht;
            this.tmp_mapa = new char[this.lenght, this.widht];
=======
            this.width = lenght;
            this.height = widht;
            mapa_Elementy = new MapElement[lenght, widht];
            this.bohater = new Player(0, 0, c);
>>>>>>> Stashed changes
        }

        public void generate()
        {
<<<<<<< Updated upstream
            int ts;
=======
            Console.Write("Generowanie mapy Prosze Czekać");
            poziom++;
            if (poziom % 3 == 0)
            {
                var sklep = new sklepki();
                sklep.generuj();
                mapa_Elementy = sklep.mapa_Elementy;
                bohater.x = 1;
                bohater.y = 1;
                Console.Clear();
            }
            else if (poziom%5==0)
            {
                var Boss = new Boss_room();
                Boss.generuj();
                mapa_Elementy = Boss.mapa_Elementy;
                mapa_Elementy[1, 7] = new MonsterBoss(1, 7, new Enemy_Boss("Random Boss",poziom));
                bohater.x = 1;
                bohater.y = 1;
                Console.Clear();
>>>>>>> Stashed changes



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
<<<<<<< Updated upstream
                        MapElement tmp_grass = new Grass(i, j);
                        this.tmp_mapa[i, j] = tmp_grass.icon;
                    }



=======
                        switch (rnd.Next(0, 200))
                        {
                            case 0:
                                mapa_Elementy[i, j] = new Chest(i, j);
                                break;
                            case 100:
                            case 150:
                                mapa_Elementy[i, j] = new Monster(i, j, new Enemy("Random Enemy",poziom));
                                break;
                            default:
                                break;
                        }
                    }
                //generowanie gracza i wyjscia
                bohater.x = rnd.Next(0, width / 2);
                bohater.y = rnd.Next(0, height);
                var a = rnd.Next(width / 2, width);
                var b = rnd.Next(0, height);
                mapa_Elementy[a, b] = new Exit(a, b);
                mapa_Elementy[bohater.x, bohater.y] = new Grass(bohater.x, bohater.y);
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

        }



        public List<MapElement> Zwroc_Sasiadow(MapElement n)
        {
            var x = n.x;
            var y = n.y;
            List<MapElement> lista = new List<MapElement>();
            if (x != 0 && x != width - 1 && y != 0 && y != height - 1)
            {
                lista.Add(mapa_Elementy[x - 1, y - 1]);
                lista.Add(mapa_Elementy[x, y - 1]);
                lista.Add(mapa_Elementy[x + 1, y - 1]);
                lista.Add(mapa_Elementy[x + 1, y]);
                lista.Add(mapa_Elementy[x + 1, y + 1]);
                lista.Add(mapa_Elementy[x, y + 1]);
                lista.Add(mapa_Elementy[x - 1, y + 1]);
                lista.Add(mapa_Elementy[x - 1, y]);
            }
            else { 

            try { lista.Add(mapa_Elementy[x - 1, y - 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x, y - 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x + 1, y - 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x + 1, y]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x + 1, y + 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x, y + 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x - 1, y + 1]); } catch (IndexOutOfRangeException) { }
            try { lista.Add(mapa_Elementy[x - 1, y]); } catch (IndexOutOfRangeException) { }
            }
            return lista;

        }



        public void ruch()//Czyta przycisk z klawiatury,i przenosi postac
        {
            var a = Console.ReadKey();
            try
            {
                switch (a.Key)
                {
                    case ConsoleKey.NumPad8:
                    case ConsoleKey.UpArrow:
                        if (!(mapa_Elementy[bohater.x, bohater.y - 1] is Rock))
                        {
                            bohater.y--;
                        }
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.DownArrow:
                        if (!(mapa_Elementy[bohater.x, bohater.y + 1] is Rock))
                        {
                            bohater.y++;
                        }
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.LeftArrow:
                        if (!(mapa_Elementy[bohater.x - 1, bohater.y] is Rock))
                        {
                            bohater.x--;
                        }
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.RightArrow:
                        if (!(mapa_Elementy[bohater.x + 1, bohater.y] is Rock))
                        {
                            bohater.x++;
                        }
                        break;
                    case ConsoleKey.NumPad1:
                        if (!(mapa_Elementy[bohater.x - 1, bohater.y + 1] is Rock))
                        {
                            bohater.x--;
                            bohater.y++;
                        }
                        break;
                    case ConsoleKey.NumPad3:
                        if (!(mapa_Elementy[bohater.x + 1, bohater.y + 1] is Rock))
                        {
                            bohater.x++;
                            bohater.y++;
                        }
                        break;
                    case ConsoleKey.NumPad7:
                        if (!(mapa_Elementy[bohater.x - 1, bohater.y - 1] is Rock))
                        {
                            bohater.x--;
                            bohater.y--;
                        }
                        break;
                    case ConsoleKey.NumPad9:
                        if (!(mapa_Elementy[bohater.x + 1, bohater.y - 1] is Rock))
                        {
                            bohater.x++;
                            bohater.y--;
                        }
                        break;
                    default:
                        break;
>>>>>>> Stashed changes
                }
            }

        }
<<<<<<< Updated upstream
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
=======





        public void show()
        {
            //kontrola Eventów
            switch (mapa_Elementy[bohater.x, bohater.y])
            {
                case Exit e:
                    generuj();
                    break;
                case Chest e:
                    mapa_Elementy[bohater.x, bohater.y] = new Grass(0, 0);
                    //daj golda(int)
                    break;
                case Monster m:
                    Versus_Show.test_show(bohater.postac, m.monster);
                    Thread.Sleep(2000);
                    if (m.monster.current_hp<=0)
                    {
                      mapa_Elementy[bohater.x, bohater.y] = new Grass(0, 0);
                    }
                    Console.Clear();
                    break;
                case MonsterBoss b:
                    Versus_Show.test_show(bohater.postac, b.monster);
                    Thread.Sleep(2000);
                    if (b.monster.current_hp <= 0)
                    {
                        mapa_Elementy[bohater.x, bohater.y] = new Grass(0, 0);
                    }
                    Console.Clear();
                    break;
                case NPC n:
                    n.Sklepikarz.Kupuj(bohater);
                    break;
                default:
                    break;
            }
            //rysowanie
            for (int i = 0; i < mapa_Elementy.GetLength(1); i++)
                {
                    for (int j = 0; j < mapa_Elementy.GetLength(0); j++)
                    {
                        if (i == bohater.y && j == bohater.x)
                        {
                            Console.Write("P");
                        }
                        else
                        {
                            Console.Write(mapa_Elementy[j, i].icon);
                        }
                    }
                    Console.WriteLine();
                }


>>>>>>> Stashed changes

        }
    }
}
