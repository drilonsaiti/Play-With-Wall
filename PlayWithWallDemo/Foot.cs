using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithWallDemo
{
    public class Foot
    {
        public Image Image { get; set; }

        public Foot()
        {

        }

        public Image getLeftSide()
        {
            Image = Properties.Resources.leftFoott;
            return Image;
        }

        public Image getRightSide()
        {
            Image = Properties.Resources.rightfooots;
            return Image;
        }

        public Image getImage()
        {
            return Image;
        }
    }
}
