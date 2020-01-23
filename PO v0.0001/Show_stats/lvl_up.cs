namespace PO_v0._0001
{
    static class lvl_up
    {
        static public void lvluj(Character character,double  pending_exp)
        {
            //metoda do lvl postaci, przypisuje określnoe statystyki zależnie od klasy.
            character.expirience = character.expirience + pending_exp;
            
            if(character.expirience>character.lvl*100)
            {
                character.lvl = character.lvl+1;
                if(character is Mage)
                {
                    character.inteligence = character.inteligence + character.inteligence * 0.40;
                    character.strength = character.strength + character.strength * 0.20;
                    character.dexterity = character.dexterity+ character.dexterity * 0.20;
                    character.max_hp = character.max_hp + character.max_hp * 0.20;
                    character.max_mp = character.max_mp + character.max_mp * 0.40;

                }
                else if(character is Warrior)
                {
                    character.inteligence = character.inteligence + character.inteligence * 0.20;
                    character.strength = character.strength + character.strength * 0.40;
                    character.dexterity = character.dexterity  +character.dexterity * 0.20;
                    character.max_hp = character.max_hp + character.max_hp * 0.40;
                    character.max_mp = character.max_mp + character.max_mp * 0.20;

                }
                else if(character is Rouge)
                {
                    character.inteligence = character.inteligence + character.inteligence * 0.20;
                    character.strength = character.strength + character.strength* 0.20;
                    character.dexterity = character.dexterity + character.dexterity* 0.40;
                    character.max_hp = character.max_hp + character.max_hp * 0.30;
                    character.max_mp = character.max_mp + character.max_mp* 0.30;
                }
                character.current_hp = character.max_hp;
                character.current_mp = character.max_mp;
                character.expirience = 0;
            }
           
            

        }
    }
}
