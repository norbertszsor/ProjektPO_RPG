namespace PO_v0._0001
{
    static class Versus_exp_dorp
    { 
       //metoda przekazująca expa pokonanego potwora do metody lvluj
        public static void gain_exp(Character player,Character monster)
        {
            lvl_up.lvluj(player, monster.expirience);
        }
    }
}
