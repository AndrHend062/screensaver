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

            switch (rand.Next(3))
            {
                case 0:
                    balls.Add(new Ball(Width, Height, Color.Red));
                    break;
                case 1:
                    balls.Add(new Ball(Width, Height, Color.IndianRed));
                    break;
                case 2:
                    balls.Add(new Ball(Width, Height, Color.PaleGoldenrod));
                    break;
            }


            
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            foreach(Ball b in balls)
            {
               foreach (Ball m in balls)
                {
                    if (b.Collision(m))
{
                        b.right = !b.right;
                        b.down = !b.down;
                        m.down = !m.down;
                        m.right = !m.right;
                        /*
                        if (rand.Next(2)==0)
                        {
                            m.down = !m.down;
                            m.right = !m.right;
                        }
                        else
                        {
                            m.down = !m.down;
                        }
                        */
                       
                    }
                }


                if (b.x <= 0||b.x+b.size >=Width-5)
                {
                    b.right = !b.right;
                }
                if (b.y <= 0 || b.y+b.size >= Height-30)
                {
                    b.down = !b.down;
                }

                b.Move();
               
               
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
