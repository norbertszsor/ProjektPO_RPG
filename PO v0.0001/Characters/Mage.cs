namespace PO_v0._0001
{
    class Mage : Character
    {
        double inteligence;
        double dexterity;
        double strength;

        public Mage(string nick) : base(nick)
        {
            this.dexterity = 2;
            this.inteligence = 8;
            this.strength = 1;
        }
    }
}
