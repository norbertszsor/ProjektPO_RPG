namespace PO_v0._0001
{
    class Weapon_Monster : Weapon // test
    {
        public Weapon_Monster()
        {
            this.name = "Monster";
            this.adaptive_demage = 1;

        }
        public void Update_adaptive_staff(Character _own_character)
        {
            this.adaptive_demage = this.adaptive_demage * _own_character.lvl * 0.50;
        }
    }
}
