namespace PO_v0._0001
{
    public static class Versus_items_drop
    {
        //metoda przekazująca itemy pokonanego potwora dla gracza
        public static void item_drop(Character _player,Character _monster)
        {
            _player.gold.value = _player.gold.value + _monster.gold.value;

        }
    }
}
