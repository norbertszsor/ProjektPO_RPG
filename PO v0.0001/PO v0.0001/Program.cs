using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
    public struct base_physical_classDamage
    {
        public const double dp_mage = 0.5;
        public const double dp_rouge = 1;
        public const double dp_warrior = 2.2;
    }

    public struct base_magic_classDemage
    {
        public const double dm_mage = 3;
        public const double dm_rouge = 1;
        public const double dm_warrior = 0.2;
    }

    public struct base_critical_classDemage
    {
        public const double dm_mage = 0.2;
        public const double dm_rouge = 5;
        public const double dm_warrior = 1;
    }

    class Character
    {
        public double expirience;
        public int lvl;
        public string nick;

        public Character( int lvl, string nick)
        {
            this.lvl = lvl;
            this.nick = nick;
        }

        public void add_expirience(double pending_exp)
        {
            //bedzie dodawac expa i lvl postac 
        }

        public void lvl_up()
        {
            // metoda do lvlowanie(norbi to huj)
        }
    }

    class Mage : Character
    {
        double inteligence;

        public Mage(int lvl, string nick, double _inteligence) : base(lvl, nick)
        {
            this.inteligence = _inteligence;
        }


    }
    class Rouge : Character
    {
        double dexterity;

        public Rouge(int lvl, string nick,double _dexterity) : base(lvl, nick)
        {
            this.dexterity = _dexterity;
        }
    }
    class Warrior : Character
    {
        double strength;

        public Warrior(int lvl, string nick, double _strenght) : base(lvl, nick)
        {
            this.strength = _strenght;
        }
    }

    class Enemy : Character
    {
        double void_force;

     

        public Enemy(int lvl, string nick, double _void_force) : base(lvl, nick)
        {
            this.void_force = _void_force;
        }

        public void create_a_monster(Character _character_enemy)
        {
            // ulepsze do postaci ze bedzie randowowalo przeciwnika z pewnych zakresow zaleznie od lvl gracza 
            double t1 = Convert.ToDouble(_character_enemy.lvl);
            double t2 = Convert.ToDouble(this.lvl);
            double t3 = t2 - t1 * 0.2;

            this.lvl = Convert.ToInt32(t3);

            this.expirience = 10000; // poznej bedzie metoda do randomowania expa z pewnych zakresow zalezne od lvl gracza

            

        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Mapa map = new Mapa(5, 6);
            map.show();
            Console.ReadKey();
        }
    }
}
