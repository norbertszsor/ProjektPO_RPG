using System;

namespace PO_v0._0001
{
    class Enemy : Character
    {
        public Enemy(string nick,int poziom_mapy) : base(nick)
        {

            this.nick = "Awilod";

            this.expirience = 30*poziom_mapy;

            this.hit_points = 30*poziom_mapy;
        }
        
    

   
    }
}
