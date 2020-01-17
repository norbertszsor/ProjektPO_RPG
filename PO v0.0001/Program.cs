using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace PO_v0._0001
{
    class beta_fight_menu
    {
      
        public void cc()
        {
            Console.Clear();
        }
       public void beta_fight_show(Character player,Character monster,Weapon weapon,Weapon enemy_weapon)
        {
            Fight_element_calculate_dmg n = new Fight_element_calculate_dmg();
            
            while(true)
            {
                if(player.hit_points>0 && monster.hit_points>0)
                {
                    cc();
                    string info = "Player " + player.hit_points + "HP ### Monster " + monster.hit_points + "HP";
                    Console.WriteLine(info);

                    Console.WriteLine(n.attack(monster, n.element_dmg_str(player, player.strength, weapon)));      
                    
                    Thread.Sleep(1500);

                    Console.WriteLine(n.attack(player, n.element_dmg_str(monster, monster.strength, enemy_weapon)));

                    Thread.Sleep(1500);

                    
                }
            }

            
        }

     
    }

  
    class Program
    {
        static void Main(string[] args)
        {
            beta_fight_menu menu_test = new beta_fight_menu();

            Character player = new Warrior("Klaps od taty");

            Weapon player_weapon = new Weapon_Warrior();
            
            Enemy cave_rat = new Enemy("Cave Rat");

            cave_rat.create_a_monster(player);

            menu_test.beta_fight_show(player, cave_rat, player_weapon,cave_rat.nowy);

            Console.ReadKey();
        }
    }
}
