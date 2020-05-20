using _bt_TrienKhaiIResizeable.Modal;
using NUnit.Framework;
using System;
using System.Transactions;

namespace NTestTrienKhailopIResizeable
{
    public class Tests
    {
        Circle circle;
        Rectangle rect;
        Square sqr;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase(0)]
        [TestCase(5)]
        [TestCase(10)]
        public void CircleGetAreaTest(double r)
        {
            circle = new Circle(r);
            Assert.AreEqual(r*r*Math.PI, circle.getArea());
        }

        [TestCase(0,5)]
        [TestCase(5, 10)]
        [TestCase(10, 20)]
        [TestCase(10, 10)]
        public void RectangleGetAreaTest(double length, double height)
        {
            rect = new Rectangle(length, height);
            Assert.AreEqual(length*height, rect.getArea());
        }

        [TestCase(0)]
        [TestCase(5)]
        [TestCase(10)]
        public void SquareGetAreaTest(double side)
        {
            sqr = new Square(side);
            Assert.AreEqual(side*side, sqr.getArea());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(0.8)]
        public void ResizeTest(double percent)
        {
            double radius = 10;
            double width = 10;
            double length = 20;
            double side = 10;

            circle = new Circle(radius);
            rect = new Rectangle(width,length);
            sqr = new Square(side);

            Assert.AreEqual(radius, circle.getRadius());
            circle.Resize(percent);
            Assert.AreEqual(radius*(1+percent), circle.getRadius());

            Assert.AreEqual(width, rect.getWidth());
            Assert.AreEqual(length, rect.getLength());
            rect.Resize(percent);
            Assert.AreEqual(width*(1+percent), rect.getWidth());
            Assert.AreEqual(length*(1+percent), rect.getLength());

            Assert.AreEqual(side, sqr.getSide());
            sqr.Resize(percent);
            Assert.AreEqual(side*(1+percent), sqr.getSide());

        }
    }
}