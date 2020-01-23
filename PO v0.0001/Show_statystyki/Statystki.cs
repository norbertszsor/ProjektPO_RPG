using System;

namespace PO_v0._0001
{
    static class Statystki
    {
        public static void show_spec_stat(Character _character)
        {
            string ramka  = "+========================+\n";
            string statsy0 = "| " + _character.nick + "\n";
            string statsy1 = "| Poziom: " + _character.lvl + "\n";
            string statsy11 ="| Inteligencja :" + _character.inteligence + "\n";
            string statsy2 = "| Siła: " + _character.strength + "\n";
            string statsy3 = "| Zręczność: " + _character.dexterity + "\n";
            string ramka2 = "+========================+";

            Console.WriteLine(ramka + statsy0 + statsy1 + statsy11 + statsy2 + statsy3 + ramka2);
        }
        public  static void show_stat(Character _character)
        {
            string ramka   = "+=======================+ \n";
            string statsy0 = "| "+_character.nick+"\n";
            string statsy1 = "| Poziom: "+_character.lvl + "\n";
            string statsy11 ="| Doświadczenie:" + _character.expirience + "\n";
            string statsy2 = "| Punkty życia: "+_character.current_hp + "/"+_character.max_hp+"\n";
            string statsy3 = "| Punkty many: "+_character.current_mp + "/" + _character.max_mp + "\n";
            string ramka2  = "========================+";


            Console.WriteLine(ramka + statsy0 + statsy1 + statsy11 + statsy2 + statsy3 + ramka2);
        }
    }
}
