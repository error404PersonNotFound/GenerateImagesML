using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace DrawBot
{
    class DataPooling
    {
        Bitmap PoolBmp (Bitmap original)
        {
            var poolResults = new List<Color>();
            for(int x = 0; x < original.Width; x++)
                for(int y = 0; y < original.Height; y++)
                {
                    int r;
                    int g;
                    int b;

                    Color pxColor1;
                    Color pxColor2 = Color.White;
                    Color pxColor3 = Color.White;
                    Color pxColor4 = Color.White;

                    pxColor1 = original.GetPixel(x, y);
                    if(!original.Height.Equals(y+1))
                        pxColor2 = original.GetPixel(x + 1, y);
                    if(!original.Width.Equals(x + 1))
                        pxColor3 = original.GetPixel(x, y + 1);
                    if(!original.Width.Equals(x + 1) && !original.Height.Equals(y + 1))
                        pxColor4 = original.GetPixel(x + 1, y + 1);


                    r = Math.Min(Math.Min(pxColor1.R, pxColor2.R), Math.Min(pxColor3.R, pxColor4.R));
                    g = Math.Min(Math.Min(pxColor1.G, pxColor2.G), Math.Min(pxColor3.G, pxColor4.G));
                    b = Math.Min(Math.Min(pxColor1.B, pxColor2.B), Math.Min(pxColor3.B, pxColor4.B));

                     
                    poolResults.Add();

                    for (int i = 0; i < 3; i++)
                    {
                        int darkest;
                        switch(i)
                        {
                            case 0:
                                darkest = 
                                break;
                            case 1:
                                darkest = Math.Min(Math.Min(pxColor1.G, pxColor2.G), Math.Min(pxColor3.G, pxColor4.G));
                                break;
                            case 2:
                                darkest = Math.Min(Math.Min(pxColor1.B, pxColor2.B), Math.Min(pxColor3.B, pxColor4.B));
                                break;
                            default:
                                darkest = -1;
                                break;
                        }

                    }
                }
        }
    }
}
