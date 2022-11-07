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
    public class GreenTests
    {
        [TestMethod()]
        public void GreenSumTest()
        {
            var rgb = new RGB(0, 133, 255);
            var g = new Green(133);
            rgb += g;
            Assert.AreEqual(133, rgb.G());
        }
    }
}