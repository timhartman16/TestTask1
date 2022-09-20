using FiguresLibrary.Figures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibraryTests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CountCircleSquareTest()
        {
            Assert.AreEqual(4 * Math.PI, new Circle(2).Square());
            Assert.AreEqual(9 * Math.PI, new Circle(3).Square());
        }

        [Test]
        public void InvalidInputTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
            Assert.Throws<ArgumentException>(() => new Circle(-30));
        }
    }
}
