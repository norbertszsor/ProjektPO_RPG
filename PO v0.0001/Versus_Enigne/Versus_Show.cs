using System;
using System.Threading;
namespace PO_v0._0001
{
    static class Versus_Show
    {
       
        public static void test_show(Character player,Character _enemy)
        {
           
            void attack_player()
            {
                Console.WriteLine(Versus_calculate.attack(_enemy, Versus_calculate.element_regular(player)));             
            }
            void attack2_player()
            {
                Console.WriteLine(Versus_calculate.attack(_enemy, Versus_calculate.element_special(player)));
                
            }           
            void atak_monster()
            {
                Console.WriteLine(Versus_calculate.attack(player, Versus_enemy.element_monster(_enemy)));//tu bedzie poziom mapy
           
            }
          

            int marker=1;
            string ramka = "+===================================+\n";
            string opjca1= "| >ATAK<  ATAK SPECJALNY   UCIEKAJ  |\n";
            string opcja2= "|  ATAK  >ATAK SPECJALNY<  UCIEKAJ  |\n";
            string opcja3 ="|  ATAK   ATAK SPECJALNY  >UCIEKAJ< |\n";
            string ramka2 ="+===================================+\n";
            void graficzna_reprezentacja()
            {
                if(marker==1)
                {
                    Console.Clear();
                    Console.WriteLine(ramka + opjca1 + ramka2) ;
                    Statystki.show_stat_combat(player);
                }
                else if(marker == 2)
                {
                    Console.Clear();
                    Console.WriteLine(ramka + opcja2 + ramka2);
                    Statystki.show_stat_combat(player);
                }
                else if(marker == 3)
                {
                    Console.Clear();
                    Console.WriteLine(ramka + opcja3 + ramka2);
                    Statystki.show_stat_combat(player);
                }
            }

            graficzna_reprezentacja();
            
            while (true)
            {

                var ch = Console.ReadKey(false).Key;
                switch (ch)
                {
               
                    case ConsoleKey.RightArrow:
                        marker = marker + 1;
                        if(marker>3)
                        {
                            marker = 1;
                        }
                        graficzna_reprezentacja();
                                            

                        break;
                    case ConsoleKey.LeftArrow:
                    
                        marker = marker - 1;
                        if (marker < 1)
                        {
                            marker = 3;
                        }
                        graficzna_reprezentacja();
                        break;

                    case ConsoleKey.Enter:
                        if(marker == 1)
                        {
                            attack_player();
                            if (player.current_hp <= 0)
                            {
                                Console.WriteLine("Jesteś martwy");
                                Thread.Sleep(2000);
                                Environment.Exit(0);
                                return;
                            }
                            else if (_enemy.current_hp <= 0)
                            {
                                Console.WriteLine(_enemy.nick + ": jest martwy");
                                Versus_exp_dorp.gain_exp(player, _enemy);
                                Versus_items_drop.item_drop(player, _enemy);
                                return;

                            }
                            Thread.Sleep(1000);                          
                            atak_monster();
                            if (player.current_hp <= 0)
                            {
                                Console.WriteLine("Jesteś martwy");
                                Thread.Sleep(2000);
                                Environment.Exit(0);
                                return;
                            }
                            else if (_enemy.current_hp <= 0)
                            {
                                Console.WriteLine(_enemy.nick + ": jest martwy");
                                Versus_exp_dorp.gain_exp(player, _enemy);
                                Versus_items_drop.item_drop(player, _enemy);
                                return;

                            }
                            Thread.Sleep(1000);
                            graficzna_reprezentacja();

                        }else if(marker == 2)
                        {
                            if(player.max_mp>49)
                            {
                                attack2_player();
                                if (player.current_hp <= 0)
                                {
                                    Console.WriteLine("Jesteś martwy");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                    return;
                                }
                                else if (_enemy.current_hp <= 0)
                                {
                                    Console.WriteLine(_enemy.nick + ": jest martwy");
                                    Versus_exp_dorp.gain_exp(player, _enemy);
                                    Versus_items_drop.item_drop(player, _enemy);
                                    return;

                                }
                                Thread.Sleep(1000);
                                atak_monster();
                                if (player.current_hp <= 0)
                                {
                                    Console.WriteLine("Jesteś martwy");
                                    Thread.Sleep(2000);
                                    Environment.Exit(0);
                                    return;
                                }
                                else if (_enemy.current_hp <= 0)
                                {
                                    Console.WriteLine(_enemy.nick + ": jest martwy");
                                    Versus_exp_dorp.gain_exp(player, _enemy);
                                    Versus_items_drop.item_drop(player, _enemy);
                                    return;

                                }
                                Thread.Sleep(1000);
                                graficzna_reprezentacja();
                            }
                            else
                            {
                                Console.WriteLine("Za mało punktów many");
                                Thread.Sleep(1000);
                                graficzna_reprezentacja();
                            }
                         

                        }
                        else if(marker == 3)
                        {
                            if(Versus_escape.run_try() == 1)
                            {
                                Console.Clear();
                                Console.WriteLine("Prubujesz powoli wycofać się z walki");
                                Thread.Sleep(2000);
                                Console.WriteLine("Przeciwnik wydaje się nie zuważyć towich ruchów, wykorzystujesz to jako szanse");
                                Thread.Sleep(2500);
                                Console.Clear();
                                Console.WriteLine("Ucieczka zakończona powodzeniem");
                                Thread.Sleep(1000);
                                return;
                                
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Prubujesz powoli wycofać się z walki");
                                Thread.Sleep(2000);
                                Console.WriteLine("Gdy wszystko szło dobrze, nagle oponent decytuje udeżyć frontalnie z całą zajadłością");
                                Thread.Sleep(3000);
                                atak_monster();
                                Thread.Sleep(1500);
                                Console.Clear();
                                Console.WriteLine("Ucieczka zakończona niepowodzeniem");
                                Thread.Sleep(1000);
                                graficzna_reprezentacja();
                            }
                            
                        }


                        break;

                  
                }
            }
        }
    }
}
