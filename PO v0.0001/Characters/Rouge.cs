namespace PO_v0._0001
{
    class Rouge : Character
    {
        double inteligence;
        double dexterity;
        double strength;

        public Rouge(string nick) : base(nick)
        {
            this.dexterity = 8;
            this.inteligence = 4;
            this.strength = 4;
        }
    }
}
