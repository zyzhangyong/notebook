using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DesktopNote
{
    class PointImage
    {
        private Image pic;

        public Image Pic
        {
            get { return pic; }
            set { pic = value; }
        }
        private Rectangle rect;

        public Rectangle Rect
        {
            get { return rect; }
            set { rect = value; }
        }
      
    }
}
