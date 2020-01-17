using System;

namespace PO_v0._0001
{
    class Enemy : Character
    {
        public Weapon nowy;
        public Enemy(string nick,int poziom_mapy) : base(nick)
        {
            this.nowy = new Weapon_Monster();

            this.nick = "Monster_test";

            this.lvl = 1;

            this.strength = 1;

            this.expirience = 120;

            this.hit_points = 60;
        }
    

   
    }
}
