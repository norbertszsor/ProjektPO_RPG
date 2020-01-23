namespace PO_v0._0001
{
    public class Rouge : Character
    {
       

        public Rouge(string nick) : base(nick)
        {
            this.dexterity = 10;
            this.inteligence = 5;
            this.strength = 5;
            this.max_hp = 60;
            this.current_hp = 60;
            this.max_mp = 100;
            this.current_mp = 100;
        }
    }
}
