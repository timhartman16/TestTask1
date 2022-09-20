using FiguresLibrary.Figures;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLibraryTests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TriangleSquareOnThreeSidesTest()
        {
            Assert.AreEqual(34.977671449083054, new Triangle(12, 10, 7).Square());
            Assert.AreEqual(6, new Triangle(5, 3, 4).Square());
        }

        [Test]
        public void InvalidInputTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-12, 10, 7));
            Assert.Throws<ArgumentException>(() => new Triangle(12, -10, 7));
            Assert.Throws<ArgumentException>(() => new Triangle(12, 10, -7));
        }

        [Test]
        public void IsRectangularTest()
        {
            Assert.True(new Triangle(3, 4, 5).IsRectangular());
            Assert.True(new Triangle(5, 12, 13).IsRectangular());
            Assert.False(new Triangle(13, 9, 5).IsRectangular());
            Assert.False(new Triangle(15, 7, 11.5).IsRectangular());
        }
    }
}
