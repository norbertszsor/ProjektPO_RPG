using System;

namespace PO_v0._0001
{
    public class Enemy : Character
    {
        public Enemy(string nick,int poziom_mapy) : base(nick)
        {

            this.nick = "Slime";

            this.expirience = 20*poziom_mapy;

            this.current_hp = 20*poziom_mapy;

            this.gold.value = 5 * poziom_mapy;
        }
        
    

   
    }
}
