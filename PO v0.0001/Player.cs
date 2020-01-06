using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
   public class Player
    {
        public int x;
        public int y;

        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void ruch(Map mapa)//Czyta przycisk z klawiatury,i przenosi postac
        {
            var a = Console.ReadKey();
            try
            {
                switch (a.Key)
                {
                    case ConsoleKey.NumPad8:
                    case ConsoleKey.UpArrow:
                        if (!(mapa.mapa_Elementy[x, y - 1] is Rock))
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.DownArrow:
                        if (!(mapa.mapa_Elementy[x, y + 1] is Rock))
                        {
                            y++;
                        }
                        break;
                    case ConsoleKey.NumPad4:
                    case ConsoleKey.LeftArrow:
                        if (!(mapa.mapa_Elementy[x - 1, y] is Rock))
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.NumPad6:
                    case ConsoleKey.RightArrow:
                        if (!(mapa.mapa_Elementy[x + 1, y] is Rock))
                        {
                            x++;
                        }
                        break;
                    case ConsoleKey.NumPad1:
                        if (!(mapa.mapa_Elementy[x - 1, y + 1] is Rock))
                        {
                            x--;
                            y++;
                        }
                        break;
                    case ConsoleKey.NumPad3:
                        if (!(mapa.mapa_Elementy[x + 1, y + 1] is Rock))
                        {
                            x++;
                            y++;
                        }
                        break;
                    case ConsoleKey.NumPad7:
                        if (!(mapa.mapa_Elementy[x - 1, y - 1] is Rock))
                        {
                            x--;
                            y--;
                        }
                        break;
                    case ConsoleKey.NumPad9:
                        if (!(mapa.mapa_Elementy[x + 1, y + 1] is Rock))
                        {
                            x++;
                            y--;
                        }
                        break;
                    default:
                        Console.WriteLine("To nie strzalka");
                        break;
                }
            }
            catch { }
            
        }
    }
}
