namespace PO_v0._0001
{
   public class Character
    {
        public double expirience;
        public int lvl;
        public string nick;

        public double hit_points;
        public double inteligence;
        public double dexterity;
        public double strength;

        public Character(string nick)
        {
            this.lvl = 1;
            this.expirience = 0.00;
            this.nick = nick;
        }

        public void Add_expirience(double pending_exp,Character character)
        {
            this.expirience = this.expirience + pending_exp;
            if(this.expirience>this.lvl*1000)
            {
                //this.Lvl_up(character);
            }
        }

        //public void Lvl_up(Character character)
        //{
        //    if(character is Mage)
        //    {
        //        this.inteligence = this.inteligence + this.inteligence * 0.25;
        //        this.strength = this.strength + this.strength * 0.05;
        //        this.dexterity = this.dexterity + this.dexterity * 0.10;
        //        this.hit_points = this.hit_points + this.strength * 0.20;
               
        //    }
        //    else if(character is Rouge)
        //    {
        //        this.inteligence = this.inteligence + this.inteligence * 0.10;
        //        this.strength = this.strength + this.strength * 0.10;
        //        this.dexterity = this.dexterity + this.dexterity * 0.30;
        //        this.hit_points = this.hit_points + this.strength * 0.30;

        //    }
        //    else if(character is Warrior)
        //    {
        //        this.inteligence = this.inteligence + this.inteligence * 0.01;
        //        this.strength = this.strength + this.strength * 0.40;
        //        this.dexterity = this.dexterity + this.dexterity * 0.10;
        //        this.hit_points = this.hit_points + this.strength * 0.60;

        //    }

        //}
    }
}
