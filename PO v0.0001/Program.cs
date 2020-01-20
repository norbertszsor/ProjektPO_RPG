using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace PO_v0._0001
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Gandalf = new Rouge("Gandalf");

            Enemy test = new Enemy("test_monster", 2);
           
            Statystki.show_stat(Gandalf);//test statystyk
            Statystki.show_spec_stat(Gandalf);

            lvl_up.lvluj(Gandalf, 200);// test lvlowania
            Statystki.show_spec_stat(Gandalf);
            Statystki.show_stat(Gandalf);// test statystyk po lvlowaniu
            
            
            lvl_up.lvluj(Gandalf, 599);
            Statystki.show_spec_stat(Gandalf);
            Statystki.show_stat(Gandalf);// test statystyk po lvlowaniu





            Versus_Show.test_show(Gandalf, test);//test walki





            Console.ReadKey();
        }
    }
}
