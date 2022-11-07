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
    public class BlueTests
    {
        [TestMethod()]
        public void BlueTest()
        {
            var rgb = new RGB(0, 65, 255);
            var b = new Blue(255);
            rgb += b;
            Assert.AreEqual(255, rgb.B());
        }
    }
}