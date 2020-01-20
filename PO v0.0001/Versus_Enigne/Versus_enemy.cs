namespace PO_v0._0001
{
    static class Versus_enemy
    {
        public static double element_monster(Character enemy)
        {
            double calculated = 0;
            calculated = enemy.hit_points * 0.15;
            return calculated;
        }

    }
}
