using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab3_12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_12.Tests
{
    [TestClass()]
    public class HSVTests
    {
        [TestMethod()]
        public void RGBToHSVTest()
        {
            var rgb = new RGB(23,65,199);
            HSV hsv = new HSV(0,0,0);
            hsv.ColorToHSV(rgb.R(),rgb.G(),rgb.B());
            double hue = hsv.HUE();
            double saturation = hsv.SAT();
            double value = hsv.VAL();
            Console.WriteLine("h = "+hue+"; s = "+saturation+"; v = "+value);
           
        }
    }
}