﻿namespace PO_v0._0001
{
    class Weapon_Rouge : Item//test
    {
        double adaptive_demage;
        public Weapon_Rouge()
        {
            this.name = "Sneaky_Dagger";
            this.adaptive_demage = 1;
        }

        public void Update_adaptive_dagger(Character _own_character)
        {
            this.adaptive_demage = this.adaptive_demage * _own_character.lvl;
        }

    }
}
