namespace PO_v0._0001
{
    class Fight_element_return_exp
    {
        public Fight_element_return_exp()
        {
        }

        void gain_exp(Character player,Character monster)
        {
            player.Add_expirience(monster.expirience, player);
        }
    }
}
