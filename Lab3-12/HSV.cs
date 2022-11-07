using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_12
{
    public class HSV
    {
        private double hue;
        private double saturation;
        private double value;
        public HSV (double hue, double saturation, double value)
        {
            this.hue = hue;
            this.saturation = saturation;
            this.value = value;
        }

        public HSV (int r, int g, int b)
        {
            ColorToHSV(r, g, b);
        }
        public HSV()
        {
            hue = 0;
            saturation = 0;
            value = 0;
        }
        public double HUE()
        {
            return hue;
        }
        public double SAT()
        {
            return saturation;
        }
        public double VAL()
        {
            return value;
        }
        public void ColorToHSV(int r, int g, int b)
        {
            double max = Math.Max(r, Math.Max(g, b));
            double min = Math.Min(r, Math.Min(g, b));

            if (max == min)
                hue = 0;
            else if (max == r && g >= b)
                hue = 60 * ((g - b) / (max - min));
            else if (max == r && g < b)
                hue = 60 * ((g - b) / (max - min)) + 360;
            else if (max == g)
                hue = 60 * ((b - r) / (max - min)) + 120;
            else if (max == b)
                hue = 60 * ((r - g) / (max - min)) + 240;

            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }
    }
}
