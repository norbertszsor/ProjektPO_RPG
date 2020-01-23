using System;

namespace PO_v0._0001
{
    static class Statystki
    {
        public static void show_spec_stat(Character _character)
        {
            string ramka  = "+============================+\n";
            string statsy0 = "| Imie: " + _character.nick + " \n";
            string statsy1 = "| Poziom: " + _character.lvl + "\n";
            string statsy2 = "| Doświadczenie:" + _character.expirience + "\n";
            string statsy6 = "| Punkty życia: " + _character.current_hp + "/" + _character.max_hp + "\n";
            string statsy7 = "| Punkty many: " + _character.current_mp + "/" + _character.max_mp + "\n";
            string statsy8 = "| Złoto: "+_character.gold.value + "\n";
            string ramka2 =  "+============================+";

            Console.WriteLine(ramka +statsy0+statsy1+statsy2+statsy6+statsy7+statsy8 + ramka2);
        }
        public  static void show_stat(Character _character)
        {
            string ramka   = "+================================+\n";
            string statsy0 = "| "+_character.nick+"\n";
            string statsy1 = "| Poziom: "+_character.lvl + "\n";
            string statsy2 = "| Doświadczenie:" + _character.expirience + "\n";
            string statsy3 = "| Punkty życia: "+_character.current_hp + "/"+_character.max_hp+"\n";
            string statsy4 = "| Punkty many: "+_character.current_mp + "/" + _character.max_mp + "\n";
            string statsy5 = "| Inteligencja :" + _character.inteligence + "\n";
            string statsy6 = "| Siła: " + _character.strength + "\n";
            string statsy7 = "| Zręczność: " + _character.dexterity + "\n";
            string statsy8 = "| Złoto: " + _character.gold.value+"\n";
            string ramka2  = "+================================+";
           

            Console.WriteLine(ramka +statsy0+statsy1+statsy2+statsy3+statsy4+statsy5+statsy6+statsy7+statsy8+ ramka2);
        }

        public static void show_stat_combat(Character _character)
        {
            string ramka = "+===================================+\n";
            string statsy0 = "| " + _character.nick + "\n";
            string statsy3 = "| Punkty życia: " + _character.current_hp + "/" + _character.max_hp + "\n";
            string statsy4 = "| Punkty many: " + _character.current_mp + "/" + _character.max_mp + "\n";
            string ramka2 = "+===================================+";
            Console.WriteLine(ramka +  statsy0+statsy3+statsy4 +ramka2);
        }
    }
}
