using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_12
{
    public class Blue
    {
        public Blue(int value)
        {
            this.value = value;
        }
        int value;
        public static RGB operator +(Blue b, RGB rgb)
        {
            return new RGB(rgb.R(), rgb.G(), (b.value + rgb.B())/2);
        }
        public static RGB operator +( RGB rgb, Blue b)
        {
            return b + rgb;
        }
    }

}
