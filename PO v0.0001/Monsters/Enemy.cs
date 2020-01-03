using System;

namespace PO_v0._0001
{
    class Enemy : Character
    {
        double inteligence;
        double dexterity;
        double strength;

        public Enemy(string nick) : base(nick)
        {
        }
    

        public void create_a_monster(Character _character_enemy)
        {
            Random rnd = new Random();

            this.nick = "Monster_test";

            this.lvl = _character_enemy.lvl - rnd.Next(1, 10);

            this.inteligence = this.inteligence - _character_enemy.lvl * 0.2;

            this.strength = this.strength - _character_enemy.lvl * 0.2;

            this.dexterity = this.dexterity - _character_enemy.lvl * 0.2;

            this.expirience = _character_enemy.expirience / 4;

        }
    }
}
