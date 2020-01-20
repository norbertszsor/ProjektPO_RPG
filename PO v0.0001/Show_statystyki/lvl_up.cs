namespace PO_v0._0001
{
    static class lvl_up
    {
        static public void lvluj(Character character,double  pending_exp)
        {
            character.expirience = character.expirience + pending_exp;
            
            if(character.expirience>character.lvl*100)
            {
                character.lvl = character.lvl+1;
                if(character is Mage)
                {
                    character.inteligence = character.inteligence + character.inteligence * 0.40;
                    character.strength = character.strength + character.strength * 0.20;
                    character.dexterity = character.dexterity+ character.dexterity * 0.20;
                    character.hit_points = character.hit_points + character.hit_points * 0.20;
                    character.mana = character.mana + character.mana * 0.40;

                }
                else if(character is Warrior)
                {
                    character.inteligence = character.inteligence + character.inteligence * 0.20;
                    character.strength = character.strength + character.strength * 0.40;
                    character.dexterity = character.dexterity  +character.dexterity * 0.20;
                    character.hit_points = character.hit_points + character.hit_points * 0.40;
                    character.mana = character.mana + character.mana * 0.20;

                }
                else if(character is Rouge)
                {
                    character.inteligence = character.inteligence + character.inteligence * 0.20;
                    character.strength = character.strength + character.strength* 0.20;
                    character.dexterity = character.dexterity + character.dexterity* 0.40;
                    character.hit_points = character.hit_points + character.hit_points* 0.30;
                    character.mana = character.mana + character.mana* 0.30;
                }
            }
            

        }
    }
}
