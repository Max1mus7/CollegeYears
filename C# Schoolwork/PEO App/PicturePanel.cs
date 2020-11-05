using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PEO_App
{
    public class PicturePanel : Panel
    {
        public PicturePanel()
        {
            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.BackgroundImageLayout = ImageLayout.Center;
        }

        public override Image BackgroundImage
        {
            get { return base.BackgroundImage; }
            set
            {
                base.BackgroundImage = value;
                if (value != null) this.AutoScrollMinSize = value.Size;
            }
        }
    }
}