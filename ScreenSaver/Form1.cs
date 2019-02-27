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
        
        public Form1()
        {
            InitializeComponent();
            OnStart();
            DoubleBuffered = true;

        }/// <summary>
        /// 
        /// </summary>
        public void OnStart()
        {
            balls.Add(new Ball(Width,Height,Color.Blue));
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {



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
