namespace PO_v0._0001
{
    class Warrior : Character
    {
     
        public Warrior(string nick) : base(nick)
        {
            this.dexterity = 4;
            this.inteligence = 2;
            this.strength = 15;
            this.hit_points = 100;
        }
    }
}
