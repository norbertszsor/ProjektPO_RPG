namespace PO_v0._0001
{
    public class Enemy_Boss : Character
    {
        public Enemy_Boss(string nick,int poziom_mapy) : base(nick)
        {
            this.nick = "Judasz Iskariota";
            this.expirience = 70 * poziom_mapy;
            this.current_hp = 70 * poziom_mapy;
            this.gold.value = 50 * poziom_mapy;
        }
    }
}
