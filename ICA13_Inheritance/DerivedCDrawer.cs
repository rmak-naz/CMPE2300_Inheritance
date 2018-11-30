using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace ICA13_Inheritance
{
    class DerivedCDrawer : CDrawer
    {
        
        public DerivedCDrawer(Bitmap bm)
            :base(bm.Width, bm.Height, false)
        {
            
            for (int iX = 0; iX < bm.Width; ++iX)
            {
                for (int iY = 0; iY < bm.Height; ++iY)
                {
                    SetBBPixel(iX, iY, bm.GetPixel(iX, iY));
                }
            }

            Render();
            
        }
        
        
    }
}
