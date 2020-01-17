namespace PO_v0._0001
{
    class Fight_element_calculate_dmg 
    {
        double recrived_dmg;
        double calculated;
        public double element_dmg_str(Character _character,double unique_skill,Weapon weapon)
        {
            this.recrived_dmg = 0;


            calculated = _character.lvl * unique_skill * weapon.adaptive_demage;

            return calculated;
        }
        public double element_dmg_dex(Character _character, double unique_skill, Weapon weapon)
        {
            this.calculated = 0;


            calculated = _character.lvl * unique_skill * weapon.adaptive_demage;

            return calculated;
        }
        public double element_dmg_int(Character _character, double unique_skill, Weapon weapon)
        {
            this.calculated = 0;


            calculated = _character.lvl * unique_skill * weapon.adaptive_demage;

            return calculated;
        }

        public string attack(Character target, double attack)
        {
           
            this.recrived_dmg = attack;
            target.hit_points = target.hit_points - recrived_dmg;

            return target.nick + " otrzymał " + recrived_dmg + " obrazen";
        }
    }
}
