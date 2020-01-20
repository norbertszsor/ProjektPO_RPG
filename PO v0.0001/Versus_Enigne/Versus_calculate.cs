using System;
using System.Threading;
namespace PO_v0._0001
{
    static class Versus_calculate
    {
       
        
        public static double element_regular(Character _character)
        {
            double calculated = 0;
            double tmp_seed;
            Random rnd = new Random();
            tmp_seed = rnd.Next(6, 12);
            int critical = rnd.Next(1, 4);
            tmp_seed = tmp_seed / 10;
            if (_character is Mage)
            {  
                calculated = _character.inteligence;
           
            }
            else if(_character is Warrior)
            {
                if (_character.hit_points< _character.hit_points*0.3)
                {
                    calculated = _character.strength;
                    calculated = calculated * 2;
                    Console.Write("Stan Beserkera: ");
                }
                else
                {
                    calculated = _character.strength;
                }
       
            }
            else if(_character is Rouge)
            {

                if(critical == 1)
                {
                    calculated = _character.dexterity * 3;
                    Console.Write("Trafienie Krytyczne!: ");
                }
                else
                {
                    calculated = _character.dexterity;
                }
         
            }


            calculated = calculated * tmp_seed+(_character.hit_points*0.1);
            return calculated;
        }

       
        public static double element_special(Character _character)
        {
            double calculated = 0;
            int tmp_seed;
            Random rnd = new Random();
            tmp_seed = rnd.Next(1, 10);

            if (_character is Mage)
            {
                calculated = _character.inteligence * 2;
                Console.Write("Magiczna Strzała: ");
                
            }
            else if (_character is Warrior)
            {
                calculated = _character.strength * 2;
                Console.Write("Rzeź: ");

            }
            else if (_character is Rouge)
            {
                calculated = _character.dexterity * 2;
                Console.Write("Cios pod żebra: ");
          
            }

            _character.mana = _character.mana - 50;
            calculated = calculated * tmp_seed;
            return calculated;
        }

        public static string attack(Character target, double attack)
        {
            double recrived_dmg;

            recrived_dmg = attack;
            target.hit_points = target.hit_points - recrived_dmg;

            return target.nick + " otrzymał " + recrived_dmg + " obrazen";
        }

   
    }
}
