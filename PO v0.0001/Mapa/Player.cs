using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
   public class Player
    {
        //reprezentacja gracza jako obiektu nie zależnego od mapy 
        //co pozwala na większą swobode jej manipulacją(generowanie nowych poziomów bez problemów z zachowaniem zmian w statystykach)
        public int x;
        public int y;
        public Character postac;
        public Player(int x, int y,Character c)
        {
            this.x = x;
            this.y = y;
            this.postac = c;
        }
      
    }
}
