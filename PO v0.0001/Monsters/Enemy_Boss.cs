namespace PO_v0._0001
{
    public class Enemy_Boss : Character
    {
        public Enemy_Boss(string nick,int poziom_mapy) : base(nick)
        {
            this.nick = "Judasz Iskariota";
            this.expirience = (50 * poziom_mapy)/2;
            this.current_hp = (60 * poziom_mapy)/2;
            this.gold.value = (50 * poziom_mapy)/2;
        }
    }
}
