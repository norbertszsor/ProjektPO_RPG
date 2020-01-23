using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PO_v0._0001
{
    public class sklepikarz
    {
        ///klasa odpowiadająca za kupywanie
        private List<string> lista = new List<string>();

        public sklepikarz()
        {
            lista.Add("|   Odzyskaj życie        -- 50g|");
            lista.Add("|   Odzyskaj mane         -- 50g|");
            lista.Add("|   Zwiększ życie         --100g|");
            lista.Add("|   Zwiększ Siłe          --100g|");
            lista.Add("|   Zwiększ Zręczność     --100g|");
            lista.Add("|   Zwiększ Inteligencje  --100g|");
            lista.Add("|             (Wyjdz)           |");
        }

        public void Kupuj(Player P)
        {
            int strzałka = 0;

            Console.Clear();

            while (true)
            {
                //rysowanie sklepu i statystyk
                Console.WriteLine("+================================+");
                for (int i = 0; i < lista.Count; i++)
                {
                    Console.Write(lista[i]);
                    if (i == strzałka)
                    {
                        Console.Write(" <<");
                    }
                    Console.WriteLine();
                }

                Statystki.show_stat(P.postac);
                //poruszanie sie po menu
                var a = Console.ReadKey();
                switch (a.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (strzałka > 0)
                        {
                            strzałka--;
                        }

                        break;
                    case ConsoleKey.DownArrow:
                        if (strzałka < 6)
                        {
                            strzałka++;
                        }
                        break;
                    //wybieranie opcji i zmianna statystyk oraz stanu złota
                    case ConsoleKey.Enter:
                        switch (strzałka)
                        {

                            case 0:
                                if (P.postac.gold.value >= 50)
                                {
                                    P.postac.gold.value -= 50;
                                    P.postac.current_hp += 50;
                                    if (P.postac.current_hp > P.postac.max_hp)
                                    {
                                        P.postac.current_hp = P.postac.max_hp;
                                    }
                                }
                                else
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("ZA MAŁO ZŁOTA");
                                }
                                break;
                            case 1:
                                if (P.postac.gold.value >= 50)
                                {
                                    P.postac.gold.value -= 50;
                                    P.postac.current_mp += 50;
                                    if (P.postac.current_mp > P.postac.max_mp)
                                    {
                                        P.postac.current_mp = P.postac.max_mp;
                                    }
                                }
                                break;
                            case 2:
                                if (P.postac.gold.value >= 100)
                                {
                                    P.postac.gold.value -= 100;
                                    P.postac.max_hp += 15;
                                }
                                else
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("ZA MAŁO ZŁOTA");
                                }
                                break;
                            case 3:
                                if (P.postac.gold.value >= 100)
                                {
                                    P.postac.gold.value -= 100;
                                    P.postac.strength += 5;
                                }
                                else
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("ZA MAŁO ZŁOTA");
                                }
                                break;
                            case 4:
                                if (P.postac.gold.value >= 100)
                                {
                                    P.postac.gold.value -= 100;
                                    P.postac.dexterity += 5;
                                }
                                else
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("ZA MAŁO ZŁOTA");
                                }
                                break;
                            case 5:
                                if (P.postac.gold.value >= 100)
                                {
                                    P.postac.gold.value -= 100;
                                    P.postac.inteligence += 5;
                                }
                                else
                                {
                                    Thread.Sleep(1000);
                                    Console.WriteLine("ZA MAŁO ZŁOTA");
                                }
                                break;
                            case 6:
                                Console.Clear();
                                return;


                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }
                Console.Clear();
            }

        }
    }
}
