using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class Form1 : Form
    {
        List<Ball> balls = new List<Ball>();
        public static Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            OnStart();
            DoubleBuffered = true;

        }
        public void OnStart()
        {
            balls.Add(new Ball(Width,Height,Color.Blue));
            gameTime.Enabled = true;
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            balls.Add(new Ball(Width, Height, Color.Red));
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            foreach(Ball b in balls)
            {

                b.Move();
               // b.Collision(balls);
                if (b.x <= 0||b.x+b.size >=Width)
                {
                    b.right = !b.right;
                }
                if (b.y <= 0 || b.y+b.size >= Height)
                {
                    b.down = !b.down;
                }
            }


            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Ball b in balls)
            {
                e.Graphics.FillEllipse(b.brush, b.x, b.y, b.size, b.size);
            }
        }

       
    }
   
}
