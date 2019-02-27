using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenSaver
{
    class Ball
    {
        public SolidBrush brush;
        
        public int x, y, xS, yS, size;
        public bool right, down;
        
        
        public Ball(int width, int height, Color colour)
        {

            x = Form1.rand.Next(width);
            y = Form1.rand.Next(height);
            xS = Form1.rand.Next(6);
            yS = Form1.rand.Next(6);
            size = Form1.rand.Next(30,50);
            right = Convert.ToBoolean(Form1.rand.Next(0, 2));
            down = Convert.ToBoolean(Form1.rand.Next(0, 2));
            brush = new SolidBrush(colour);

            
        }
        public void Move()
        {
            if (right)
            {
                x = x + xS;
            }
            else
            {
                x = x - xS;
            }

            if (down)
            {
                y = y + yS;
            }
            else
            {
                y = y - yS;
            }
        }

        public Boolean Collision(Ball b)
        {

            Rectangle rect = new Rectangle(x, y, size, size);
            Rectangle ballRect = new Rectangle(b.x, b.y, b.size, b.size);
            return rect.IntersectsWith(ballRect);
            
            
        }
    }
}
