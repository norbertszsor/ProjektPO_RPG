using System;
using System.Threading;
namespace PO_v0._0001
{
    public static class Versus_Menu
    {
        public static Character Menu()
        {

            int marker = 1;
            int marker2 = 1;
            int marker3 = 1;
            

            void Menu_element_create_champion()
            {
                string ramka_menu = "+============+\n";
                string opjca1_menu = "|   >MAG<    |\n" + "|   ŁOWCA    |\n" + "|  WOJOWNIK  |\n";
                string opcja2_menu = "|    MAG     |\n" + "|  >ŁOWCA<   |\n" + "|  WOJOWNIK  |\n";
                string opcja3_menu = "|    MAG     |\n" + "|   ŁOWCA    |\n" + "| >WOJOWNIK< |\n";
                string ramka2_menu = "+============+\n";

                if (marker3 == 1)
                {
                    Console.Clear();
                    Console.WriteLine(ramka_menu + opjca1_menu + ramka2_menu);
                }
                else if (marker3 == 2)
                {
                    Console.Clear();
                    Console.WriteLine(ramka_menu + opcja2_menu + ramka2_menu);
                }
                else if (marker3 == 3)
                {
                    Console.Clear();
                    Console.WriteLine(ramka_menu + opcja3_menu + ramka2_menu);
                }
            }



            
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
                                    //////////////////////////////////////////////////////////////////////////////////////////////////////    
                                        if(marker2 == 1)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("+==============================+");
                                            Console.WriteLine("| PODAJ IMIE SWOJEGO BOHATERA: |");
                                            Console.WriteLine("+==============================+");
                                            var name = Console.ReadLine();
                                           
                                            hello_txt();
                                            

                                            Menu_element_create_champion();
                                            while (true)
                                            {
                                                

                                                    

                                                var key3 = Console.ReadKey(false).Key;
                                                switch(key3)
                                                {
                                                    case ConsoleKey.DownArrow:
                                                        marker3 = marker3 + 1;
                                                        if (marker3 > 3)
                                                        {
                                                            marker3 = 1;
                                                        }
                                                        Menu_element_create_champion();
                                                        break;

                                                    case ConsoleKey.UpArrow:
                                                        marker3 = marker3 - 1;
                                                        if (marker3 < 1)
                                                        {
                                                            marker3 = 3;
                                                        }
                                                        Menu_element_create_champion();
                                                        break;
                                                    case ConsoleKey.Enter:

                                                        if (marker3 == 1)
                                                        {
                                                            Character mag = new Mage(name);
                                                            return mag;
                                                        }
                                                        else if (marker3 == 2)
                                                        {
                                                            Character łowca = new Rouge(name);
                                                            return łowca;
                                                        }
                                                        else if(marker3 == 3)
                                                        {
                                                            Character wojownik = new Warrior(name);
                                                            return wojownik;
                                                        }




                                                        break;
                                                }
                                                
                                            }
                                        }
                                        else if(marker2 ==2)
                                        {
                                            Menu();
                                        }

                                   ///////////////////////////////////////////////////////////////////////////////////////////////////////
                                        break;

                                    case ConsoleKey.Escape:

                                        break;

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
            void hello_txt()
            {
                Console.Clear();
                Console.WriteLine("+===============================================================+");
                Console.WriteLine("|                                                               |");
                Console.WriteLine("|  Byłeś zwykłym synem wieśniaka, aż do dzisiaj kiedy stoisz    |");
                Console.WriteLine("|  przed dziwnymi wrotami, które prowadzą w nieznaną do tąd     |");
                Console.WriteLine("|  pustkę w podziemiach, twoje życie było nudne i pełne pracy   |");
                Console.WriteLine("|  w polu, teraz nadzszedł czas na twoją przygodę, podchodzisz  |");
                Console.WriteLine("|  do dziwnych wrót które wydają się być ciepłe w dotyku        |");
                Console.WriteLine("|  nagle słyszysz dzwięk, który rozlewa się po twoim wnętrzu    |");
                Console.WriteLine("|                                                               |");
                Console.WriteLine("|                   >WYBIERZ SWOJĄ KLASĘ<                       |");
                Console.WriteLine("+===============================================================|");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
