using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDZ.Interfaces
{
    internal interface FrameServiceInterface
    {
        Bitmap CreateFrame();
        Bitmap CreateBackFillFrame();
        void SaveFrame(ref Bitmap image, string Path);
    }
}
