using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ap2210
{
    public partial class Form1 : Form
    {
        bool isClicked = false;

        int deltaX = 0, deltaY = 0;
        Rectangle rect = new Rectangle(10, 10, 200, 30);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black);

            e.Graphics.DrawRectangle(pen, rect);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isClicked = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClicked)
            {
                rect.X = e.X - deltaX;
                rect.Y = e.Y - deltaY;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.X < rect.X + rect.Width) && (e.X > rect.X))
                if ((e.Y < rect.Y + rect.Height) && (e.Y > rect.Y))
                {
                    isClicked = true;
                    deltaX = e.X - rect.X;
                    deltaY = e.Y - rect.Y;
                }
        }
    }
}
