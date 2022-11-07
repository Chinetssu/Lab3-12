using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_12
{
    public class Red
    {
        public Red (int value)
        {
            this.value = value;
        }
        int value;
        public static RGB operator+(Red r, RGB rgb)
        {

            return new RGB((r.value+rgb.R())/2,rgb.G(),rgb.B());
        }
        public static RGB operator+( RGB rgb, Red r)
        {
            return r + rgb;
        }
    }
}
