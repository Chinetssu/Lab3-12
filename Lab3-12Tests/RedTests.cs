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
    public class RedTests
    {
        [TestMethod()]
        public void RedSumTest()
        {
            var rgb = new RGB(0, 65, 255);
            var r = new Red(255);
            rgb += r;
            Assert.AreEqual(127, rgb.R());
        }
    }
}