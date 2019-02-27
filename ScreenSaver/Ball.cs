using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ScreenSaver
{
    class Ball
    {
        public SolidBrush brush;
        Random rand = new Random();
        public int x, y, xS, yS, size;
        public bool right, down;
        public Ball(int width, int height, Color colour)
        {

            x = rand.Next(width);
            y = rand.Next(height);
            xS = rand.Next(10);
            yS = rand.Next(10);
            size = rand.Next(10);
            right = Convert.ToBoolean(rand.Next(0, 2));
            down = Convert.ToBoolean(rand.Next(0, 2));
            brush = new SolidBrush(colour);
        }
    }
}
