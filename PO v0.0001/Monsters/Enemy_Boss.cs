namespace PO_v0._0001
{
    class Enemy_Boss : Character
    {
        public Enemy_Boss(string nick,int poziom_mapy) : base(nick)
        {
            this.nick = "Mwu-san";
            this.expirience = 100 * poziom_mapy;
            this.hit_points = 100 * poziom_mapy;
        }
    }
}
