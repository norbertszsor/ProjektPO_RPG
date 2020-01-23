namespace PO_v0._0001
{
    public class Character
    {
        public double expirience;
        public int lvl;
        public string nick;


        public Gold_Coin gold = new Gold_Coin();
        public double current_hp;
        public double max_hp;
        public double inteligence;
        public double dexterity;
        public double strength;
        public double current_mp;
        public double max_mp;

        public Character(string nick)
        {
            this.lvl = 1;
            this.expirience = 0.00;
            this.nick = nick;
            this.gold.value = 0;
        }

      

       
    }
}
