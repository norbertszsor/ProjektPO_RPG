namespace PO_v0._0001
{
    class Warrior : Character
    {
        double inteligence;
        double dexterity;
        double strength;

        public Warrior(string nick) : base(nick)
        {
            this.dexterity = 4;
            this.inteligence = 0.2;
            this.strength = 15;
        }
    }
}
