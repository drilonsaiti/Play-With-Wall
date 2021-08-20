using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayWithWallDemo
{
    public class Wall
    {
        public Image wallTop;
        public Image wallLeft;
        public Image wallRight;
        public Image wallBottom;

        public Wall()
        {
            wallTop = Properties.Resources.wallTop;
            wallLeft = Properties.Resources.wallSide;
            wallRight = Properties.Resources.wallSide;
            wallBottom = Properties.Resources.wallTop;
        }

        public void drawTopWall(Graphics g)
        {
            g.DrawImage(wallTop, -2, 3, 1060, 15);
        }

        public void drawLeftWall(Graphics g)
        {
            g.DrawImage(wallLeft, -1, 4, 15, 620);
        }

        public void drawRightWall(Graphics g)
        {
            g.DrawImage(wallRight, 1044, 4, 15, 620);
        }

        public void drawBottomWall(Graphics g)
        {
            g.DrawImage(wallBottom, 3, 604, 1060, 15);
        }
    }
}
