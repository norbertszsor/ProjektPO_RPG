namespace PO_v0._0001
{
    class Character
    {
        public double expirience;
        public int lvl;
        public string nick;

        public double hit_points;
        public double inteligence;
        public double dexterity;
        public double strength;
        public double mana;

        public Character(string nick)
        {
            this.lvl = 1;
            this.expirience = 0.00;
            this.nick = nick;
        }

      

       
    }
}
