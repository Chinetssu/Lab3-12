using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_12
{
    public class Green
    {
        public Green(int value)
        {
            this.value = value;
        }
        int value;
        public static RGB operator +(Green g, RGB rgb)
        {
            return new RGB(rgb.R(), (g.value + rgb.G())/2, rgb.B());
        }
        public static RGB operator +(RGB rgb, Green g)
        {
            return g + rgb;
        }
    }
}
