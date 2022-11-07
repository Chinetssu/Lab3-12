using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_12
{
    class Logic
    {
        static RGB imaginaryHSV = new RGB();
        public static RGB getImaginaryHSV(double hue, double saturation, double value)
        {
            imaginaryHSV.ColorFromHSV(hue, saturation, value);
            return imaginaryHSV;
        }
    }
}
