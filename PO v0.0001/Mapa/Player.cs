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
        public Character postac;
        public Player(int x, int y,Character c)
        {
            this.x = x;
            this.y = y;
            this.postac = c;
        }
      
    }
}
