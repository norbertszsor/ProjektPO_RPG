namespace PO_v0._0001
{
    static class Versus_enemy
    {
        //metoda obliczająca wartość ataku potworów
        public static double element_monster(Character enemy)
        {
            double calculated = 0;
            calculated = enemy.current_hp * 0.15;
            return calculated;
        }

    }
}
