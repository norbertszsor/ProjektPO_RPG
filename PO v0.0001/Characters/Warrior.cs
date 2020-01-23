namespace PO_v0._0001
{
    public class Warrior : Character
    {
     
        public Warrior(string nick) : base(nick)
        {
            this.dexterity = 5;
            this.inteligence = 5;
            this.strength = 10;
            this.max_hp = 100;
            this.current_hp = 100;
            this.max_mp = 50;
            this.current_mp = 50;
        }
    }
}
