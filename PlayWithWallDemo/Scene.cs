using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayWithWallDemo
{
    public class Scene
    {
        public Ball Ball { get; set; }
        public Foot Foot { get; set; }
        public Wall Wall { get; set; }
        public int speed_left { get; set; }
        public int speed_top { get; set; }

        public Scene()
        {
            Ball = new Ball();
            Foot = new Foot();
            Wall = new Wall();
            speed_left = 4;
            speed_top = 4;
        }

        public bool isTouching(PictureBox ball, PictureBox foot)
        {

            if (ball.Bottom >= foot.Top && ball.Bottom <= foot.Bottom && ball.Left >= foot.Left && ball.Right <= foot.Right)
            {
                speed_left += 1;
                speed_top += 1;
                speed_top = -speed_top;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void moveBall(PictureBox ball)
        {
            if (ball.Left <= 4)
            {
                speed_left = -speed_left;
            }

            if (ball.Right >= 1044)
            {
                speed_left = -speed_left;
            }

            if (ball.Top <= Wall.wallTop.Height)
            {
                speed_top = -speed_top;
            }

        }

        /*public int MoveFoot(int c)
        {
            // return c - (Foot.getImage().Width / 2);
        }*/

        public bool ballIsOut(int ballBottom, int groundBottom)
        {
            if (ballBottom >= groundBottom)
                return true;
            return false;
        }
    }
}
