using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO_v0._0001.Properties
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

        public Rock(int x, int y) : base(x, y)
        {
            this.icon = 'R';
        }
    }
    
}
