using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BrickBreaker
{
    public class Block
    {
        public int width = 50;
        public int height = 25;

        public int x;
        public int y; 
        public int hp;
        public int score; // TODO: Have bricks in a designed level have more points or less
        
        /// <summary>
        /// Gets the color based on the hp
        /// </summary>
        /// <returns></returns>
        public Color colour()
        {
            switch(hp)
            {
                case 1:
                    return Color.Red;
                case 2:
                    return Color.Yellow;
                case 3:
                    return Color.Green;
                default:
                    return Color.Orange;
            }
        }

        public static Random rand = new Random();

        public Block(string _x, string _y, string _hp)
        {
            x = Convert.ToInt32(_x);
            y = Convert.ToInt32(_y);
            hp = Convert.ToInt32(_hp);
        }
    }
}
