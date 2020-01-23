using System;
using System.Threading;
namespace PO_v0._0001
{
    public static class Versus_Menu
    {
        public static void Menu()
        {

            int marker = 1;
            int marker2 = 1;
         




            
            void Menu_element_create()
            {
                
                string ramka_menu =  "+===================+\n";
                string opjca1_menu = "| >STWÓRZ BOHATERA< |\n" + "|      POWRÓT       |\n";
                string opcja2_menu = "|  STWÓRZ BOHATERA  |\n" + "|     >POWRÓT<      |\n";
                string ramka2_menu = "+===================+\n";


                if(marker2 == 1)
                {
                    Console.Clear();
                    Console.WriteLine(ramka_menu + opjca1_menu + ramka2_menu);
                }
                else if(marker2 ==2)
                {
                    Console.Clear();
                    Console.WriteLine(ramka_menu + opcja2_menu + ramka2_menu);
                }
            }


            void Menu_element()
            {
                string ramka_menu = "+============+\n";
                string opjca1_menu = "| >NOWA GRA< |\n" + "|   AUTORZY  |\n" + "|    WYJDŹ   |\n";
                string opcja2_menu = "|  NOWA GRA  |\n" + "|  >AUTORZY< |\n" + "|    WYJDŹ   |\n";
                string opcja3_menu = "|  NOWA GRA  |\n" + "|   AUTORZY  |\n" + "|   >WYJDŹ<  |\n";
                string ramka2_menu = "+============+\n";


                if (marker == 1)
                {
                    Console.Clear();
                    Console.WriteLine(ramka_menu + opjca1_menu + ramka2_menu);
                }
                else if (marker == 2)
                {
                    Console.Clear();
                    Console.WriteLine(ramka_menu + opcja2_menu + ramka2_menu);
                }
                else if (marker == 3)
                {
                    Console.Clear();
                    Console.WriteLine(ramka_menu + opcja3_menu + ramka2_menu);
                }
            }


            Menu_element();

            while (true)
            {

                var key = Console.ReadKey(false).Key;
                switch(key)
                {
                    case ConsoleKey.DownArrow:
                        marker = marker + 1;
                        if (marker > 3)
                        {
                            marker = 1;
                        }
                        Menu_element();
                        break;
                    case ConsoleKey.UpArrow:
                        marker = marker - 1;
                        if (marker < 1)
                        {
                            marker = 3;
                        }
                        Menu_element();
                        break;

                    case ConsoleKey.Enter:
                        
                        
                        if(marker==1)
                        {
                            Menu_element_create();
                            while(true)

                            {

                                var key2 = Console.ReadKey(false).Key;
                                switch (key2)
                                {
                                    case ConsoleKey.DownArrow:
                                        marker2 = marker2 + 1;
                                        if (marker2 > 3)
                                        {
                                            marker2 = 1;
                                        }
                                        Menu_element_create();
                                        break;

                                    case ConsoleKey.UpArrow:
                                        marker2 = marker2 - 1;
                                        if (marker2 < 1)
                                        {
                                            marker2 = 3;
                                        }
                                        Menu_element_create();
                                        break;

                                    case ConsoleKey.Enter:
                                        
                                        if(marker2 == 1)
                                        {

                                        }
                                        else if(marker2 ==2)
                                        {
                                            Menu();
                                        }



                                        break;

                                    case ConsoleKey.Escape:

                                        return;

                                }



                            }

                        }
                        else if(marker ==2)
                        {
                            Console.Clear();
                            Console.WriteLine("+======================================+");
                            Console.WriteLine("|      ReDream Dungeon ver.000001      |");
                            Console.WriteLine("| Norbert Szmigero && Jakub Szatybełko |");
                            Console.WriteLine("+======================================+");
                            Console.WriteLine("\n\nWciśnij dowolny klawisz...");
                            Console.ReadKey();
                            Menu();
                        }
                        else if(marker == 3)
                        {
                            Console.Clear();
                            Console.Write("Kończenie");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Console.Write(".");
                            Thread.Sleep(500);
                            Environment.Exit(0);
                        }




                        break;
                }

               
            }
        }
    }
}
