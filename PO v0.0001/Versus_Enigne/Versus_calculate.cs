using System;
using System.Threading;
namespace PO_v0._0001
{
    static class Versus_calculate
    {
        //metody obliczające wartość ataku
       
        
        public static double element_regular(Character _character)
        {
            //metoda oblicz wartość ataku dla ataku podstawowego
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
                //wojownik wpada w szał jeżeli osiągnie mniej niż 30% zdrowia
                if (_character.current_hp< _character.current_hp*0.3)
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
                //łowca ma szanse 1/4 na zadanie ataku krytycznego

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


            calculated = calculated * tmp_seed+(_character.current_hp*0.1);
            return calculated;
        }

       
        public static double element_special(Character _character)
        {
            //metoda do wyliczania ataku specjalnego, tzw czaru
            double calculated = 0;
            double tmp_seed;
            Random rnd = new Random();
            tmp_seed = rnd.Next(10, 16);
            tmp_seed = tmp_seed / 10;

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
            if(_character.current_mp>=50)
            {
                _character.current_mp = _character.current_mp - 50;
                return calculated;
            }
            else
            {
                return 0;
            }


            
        }

        public static string attack(Character target, double attack)
        {
            //klasa która służy do wyświatlania ataku i zabierania życia przeciwnikowi
            double recrived_dmg;

            if(attack == 0)
            {
                return "Za mało many";

            }
            else
            {
                recrived_dmg = attack;
                target.current_hp = target.current_hp - recrived_dmg;


                return target.nick + " otrzymał " + String.Format("{0:0.0}", recrived_dmg) + " obrazen";
            }
          
        }

   
    }
}
