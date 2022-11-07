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
    public class RGBTests
    {
        [TestMethod()]
        public void ColorFromHSVToRGBTest()
        {
            var frgb = new RGB(23, 65, 199);
            var rgb = new RGB(0, 0, 0);
            HSV hsv = new HSV(226, 0.88, 0.78);
            hsv.ColorToHSV(frgb.R(),frgb.G(),frgb.B());
            rgb.ColorFromHSV(hsv.HUE(), hsv.SAT(), hsv.VAL());
            Console.WriteLine("r = "+rgb.R() + "; g = "+rgb.G()+"; b = "+rgb.B());
            Assert.AreEqual(23, rgb.R());
        }
    }
}