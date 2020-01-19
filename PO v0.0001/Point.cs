using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{

    public class MapElement
    {

        public char icon;
        public int x;
        public int y;

        public MapElement(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Grass : MapElement
    {

        public Grass(int x, int y) : base(x, y)
        {
            icon = '.';

        }
    }
    public class Rock : MapElement
    {

        public Rock(int x, int y) : base(x, y)
        {
            icon = '█';
        }
    }

    public class Exit : MapElement
    {

        public Exit(int x, int y) : base(x, y)
        {
            icon = '░';
        }
    }
    public class Chest : MapElement
    {

        public Chest(int x, int y) : base(x, y)
        {
            icon = '☼';
        }
    }
    public class Monster : MapElement
    {
        public Enemy monster = new Enemy("ziomek");
        public Monster(int x, int y) : base(x, y)
        {
            icon = '☺';
        }
    }
    public class Node_Generatora : MapElement
    {
        public Node_Generatora(int x, int y) : base(x, y)
        {
            icon = '*';
        }
    }
    public class NPC : MapElement
    {
        public NPC(int x, int y) : base(x, y)
        {
            icon = '$';
        }
    }
}
