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

        double inteligence;
        double dexterity;
        double strength;

        public Character(string nick)
        {
            this.lvl = 1;
            this.expirience = 0.00;
            this.nick = nick;
        }

        public void add_expirience(double pending_exp,Character character)
        {
            this.expirience = this.expirience + pending_exp;
            if(this.expirience>this.lvl*1000)
            {
                this.lvl_up(character);
            }
        }

        public void lvl_up(Character character)
        {
            if(character is Mage)
            {
                this.inteligence = this.inteligence + this.inteligence * 0.25;
                this.strength = this.strength + this.strength * 0.05;
                this.dexterity = this.dexterity + this.dexterity * 0.10;
               
            }
            else if(character is Rouge)
            {
                this.inteligence = this.inteligence + this.inteligence * 0.10;
                this.strength = this.strength + this.strength * 0.10;
                this.dexterity = this.dexterity + this.dexterity * 0.30;

            }
            else if(character is Warrior)
            {
                this.inteligence = this.inteligence + this.inteligence * 0.01;
                this.strength = this.strength + this.strength * 0.40;
                this.dexterity = this.dexterity + this.dexterity * 0.10;

            }

        }
    }

    class Mage : Character
    {
        double inteligence;
        double dexterity;
        double strength;

        public Mage(string nick) : base(nick)
        {
            this.dexterity = 2;
            this.inteligence = 8;
            this.strength = 1;
        }
    }
    class Rouge : Character
    {
        double inteligence;
        double dexterity;
        double strength;

        public Rouge(string nick) : base(nick)
        {
            this.dexterity = 8;
            this.inteligence = 4;
            this.strength = 4;
        }
    }
    class Warrior : Character
    {
        double inteligence;
        double dexterity;
        double strength;

        public Warrior(string nick) : base(nick)
        {
            this.dexterity = 4;
            this.inteligence = 0.2;
            this.strength = 15;
        }
    }

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
            this.inteligence = this.inteligence - _character_enemy.lvl * 0.2;
            this.strength = this.strength - _character_enemy.lvl * 0.2;
            this.strength = this.strength - _character_enemy.lvl * 0.2;

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Map mapa = new Map(30, 20);
            mapa.generate();
            
            while (true)
            {
                
                mapa.show();
                mapa.bohater.ruch(mapa);
                Console.Clear();
            }

            Console.ReadKey();
          
        }
    }
}
