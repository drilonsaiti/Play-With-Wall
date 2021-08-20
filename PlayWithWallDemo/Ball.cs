using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithWallDemo
{
    public class Ball
    {

        public Image Image { get; set; }

        public Ball()
        {
            Image = Properties.Resources.ball;
        }

        public Image getImage()
        {
            return Image;
        }
    }
}
