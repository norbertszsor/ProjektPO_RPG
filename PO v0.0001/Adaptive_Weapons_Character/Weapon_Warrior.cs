namespace PO_v0._0001
{
    class Weapon_Warrior : Item//test
    {
        double adaptive_demage;
        public Weapon_Warrior()
        {
            this.name = "Giant_Sword";
            this.adaptive_demage = 1;
        }

        public void Update_adaptive_sword(Character _own_character)
        {
            this.adaptive_demage = this.adaptive_demage * _own_character.lvl;
        }

    }
}
