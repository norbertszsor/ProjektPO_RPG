namespace PO_v0._0001
{
    //klasa bohatera
    public class Mage : Character
    {
    
        public Mage(string nick) : base(nick)
        {
            this.dexterity = 5;
            this.inteligence = 10;
            this.strength = 5;
            this.max_hp = 40;
            this.current_hp = 40;
            this.max_mp = 180;
            this.current_mp = 180;
                       
        }

   
    }
}
