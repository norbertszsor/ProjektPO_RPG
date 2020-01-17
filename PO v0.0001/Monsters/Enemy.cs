using System;

namespace PO_v0._0001
{
    class Enemy : Character
    {
        public Weapon nowy;
        public Enemy(string nick) : base(nick)
        {
            this.nowy = new Weapon_Monster();
        }
    

        public void create_a_monster(Character _character_enemy)
        {

            // tu bedzie metoda wyliczania poziomu zależnie od poziomu mapy


            this.nick = "Monster_test";

            this.lvl = 1;

            this.strength = 1;

            this.expirience = 120;

            this.hit_points = 60;

        }
    }
}
