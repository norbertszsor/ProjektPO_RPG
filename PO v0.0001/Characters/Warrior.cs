namespace PO_v0._0001
{
    class Warrior : Character
    {
     
        public Warrior(string nick) : base(nick)
        {
            this.dexterity = 5;
            this.inteligence = 5;
            this.strength = 10;
            this.hit_points = 100;
            this.mana = 50;
        }
    }
}
