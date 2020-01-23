using System;
using System.Collections.Generic;

namespace PO_v0._0001
{
    //bazowy przeciwnik, generowany na podstawie klasy Character, zwiększa swoją siłe z każdym poziomem mapy
    public class Enemy : Character
    {
        
        
        public Enemy(string nick,int poziom_mapy) : base(nick)
        {
            
            this.nick = "Slime"; //miało losować z 12 dostępnych imion, z powodu braku czasu nie dokończone

            this.expirience = 20*poziom_mapy;

            this.current_hp = 20*poziom_mapy;

            this.gold.value = 5 * poziom_mapy;
        }
        
    

   
    }
}
