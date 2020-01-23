using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001
{
    public class Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class MapElement : Point
    {

        public char icon;
        public string position;

        public MapElement(int x, int y) : base(x, y)
        {

        }
    }
    public class Grass : MapElement
    {

        public Grass(int x, int y) : base(x, y)
        {
            this.icon = '.';

        }
    }
    public class Rock : MapElement
    {

<<<<<<< Updated upstream
        public Rock(int x, int y) : base(x, y)
=======
        public Chest(int x, int y) : base(x, y)
        {
            icon = '☼';
        }
    }
    public class Monster : MapElement
    {
        public Enemy monster;
        public Monster(int x, int y,Enemy m) : base(x, y)
        {
            icon = '☺';
            this.monster = m;
        }
    }
    public class MonsterBoss : MapElement
    {
        public Enemy_Boss monster;
        public MonsterBoss(int x, int y, Enemy_Boss m) : base(x, y)
        {
            icon = '☺';
            this.monster = m;
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
        public sklepikarz Sklepikarz=new sklepikarz();
        public NPC(int x, int y) : base(x, y)
>>>>>>> Stashed changes
        {
            this.icon = 'R';
        }

       
    }
}
