namespace PO_v0._0001
{//classa broni z powodu braku czasu nie dodane
    class Weapon_Mage : Weapon // test
    {
        public Weapon_Mage()
        {
            this.name = "Dragon_Staff";
            this.adaptive_demage = 1;

        }
        public void Update_adaptive_staff(Character _own_character)
        {
            this.adaptive_demage = this.adaptive_demage * _own_character.lvl;
        }
    }
}
