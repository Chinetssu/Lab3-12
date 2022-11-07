using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_12
{
    public class RGB
    {
        private int r;
        private int g;
        private int b;
        public RGB (int r, int g, int b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public RGB (double h, double s, double v)
        {
            ColorFromHSV(h, s, v);
        }
        public RGB()
        {
            r = 0;
            g = 0;
            b = 0;
        }
        public int R()
        {
            return r;
        }
        public int G()
        {
            return g;
        }
        public int B()
        {
            return b;
        }
        public void ColorFromHSV(double hue, double saturation, double value)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
            {
                r = v;
                g = t;
                b = p;
            }
            else if (hi == 1)
            {
                r = q;
                g = v;
                b = p;
            }
            else if (hi == 2)
            {
                r = p;
                g = v;
                b = t;
            }
                    else if (hi == 3)
            {
                r = p;
                g = q;
                b = v;
            }
                    else if (hi == 4)
            {
                r = t;
                g = p;
                b = v;
            }
            else
            {
                r = v;
                g = p;
                b = q;
            }
        }
    }
}
