using System;

namespace PO_v0._0001
{
    static class Statystki
    {
        //zestaw statycznych metod wyświetlających dane o bochaterze w różnych miejscach gry
        public static void show_spec_stat(Character _character)
        {
            string ramka  = "+============================+\n";
            string statsy0 = "| Imie: " + _character.nick + " \n";
            string statsy1 = "| Poziom: " + _character.lvl + "\n";
            string statsy2 = "| Doświadczenie:" + String.Format("{0:0.0}", _character.expirience) + "\n";
            string statsy6 = "| Punkty życia: " + String.Format("{0:0.0}", _character.current_hp) + "/" + String.Format("{0:0.0}", _character.max_hp) + "\n";
            string statsy7 = "| Punkty many: " + String.Format("{0:0.0}", _character.current_mp) + "/" + String.Format("{0:0.0}", _character.max_mp) + "\n";
            string statsy8 = "| Złoto: "+ String.Format("{0:0.0}", _character.gold.value) + "\n";
            string ramka2 =  "+============================+";

            Console.WriteLine(ramka +statsy0+statsy1+statsy2+statsy6+statsy7+statsy8 + ramka2);
        }
        public  static void show_stat(Character _character)
        {
            
            string ramka   = "+================================+\n";
            string statsy0 = "| "+_character.nick+"\n";
            string statsy1 = "| Poziom: "+_character.lvl + "\n";
            string statsy2 = "| Doświadczenie:" + String.Format("{0:0.0}", _character.expirience) + "\n";
            string statsy3 = "| Punkty życia: "+ String.Format("{0:0.0}", _character.current_hp) + "/"+String.Format("{0:0.0}", _character.max_hp)+ "\n";
            string statsy4 = "| Punkty many: "+ String.Format("{0:0.0}", _character.current_mp) + "/" + String.Format("{0:0.0}", _character.max_mp) + "\n";
            string statsy5 = "| Inteligencja :" + String.Format("{0:0.0}", _character.inteligence) + "\n";
            string statsy6 = "| Siła: " + String.Format("{0:0.0}", _character.strength) + "\n";
            string statsy7 = "| Zręczność: " + String.Format("{0:0.0}", _character.dexterity) + "\n";
            string statsy8 = "| Złoto: " + String.Format("{0:0.0}", _character.gold.value) + "\n";
            string ramka2  = "+================================+";
           

            Console.WriteLine(ramka +statsy0+statsy1+statsy2+statsy3+statsy4+statsy5+statsy6+statsy7+statsy8+ ramka2);
        }

        public static void show_stat_combat(Character _character)
        {
            string ramka = "+===================================+\n";
            string statsy0 = "| " + _character.nick + "\n";
            string statsy3 = "| Punkty życia: " + String.Format("{0:0.0}", _character.current_hp) + "/" + String.Format("{0:0.0}", _character.max_mp) + "\n";
            string statsy4 = "| Punkty many: " + String.Format("{0:0.0}", _character.current_mp) + "/" + String.Format("{0:0.0}", _character.max_mp) + "\n";
            string ramka2 = "+===================================+";
            Console.WriteLine(ramka +  statsy0+statsy3+statsy4 +ramka2);
        }
    }
}
