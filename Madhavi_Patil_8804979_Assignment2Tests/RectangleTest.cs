using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Madhavi_Patil_8804979_Assignment2;

namespace Madhavi_Patil_8804979_Assignment2Tests
{
    //Test cases
    public class RectangleTest
    {
        [TestFixture]

        public class RectangleTest1
        {
            [Test]


            public void RectangleLength_Input3()
            {
                Rectangle rectangle = new Rectangle(3,6);
                int expected = 3;
                int actual = rectangle.GetLength();
                Assert.AreEqual(expected, actual);
            }
        }
        [TestFixture]
        public class RectangleTest2
        {
            [Test]


            public void RectangleLength_Input7()
            {
                Rectangle rectangle = new Rectangle(7, 10);
                int expected = 7;
                int actual = rectangle.GetLength();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest3
        {
            [Test]


            public void RectangleLength_Input2()
            {
                Rectangle rectangle = new Rectangle(2, 5);
                int expected = 2;
                int actual = rectangle.GetLength();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest4
        {
            [Test]
            public void RectangleLength_Input5()
            {
                Rectangle rectangle = new Rectangle(5, 10);
                
                int actual = rectangle.SetLength(5);
                int expected = 5;
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest5
        {
            [Test]
            public void RectangleLength_Input2()
            {
                Rectangle rectangle = new Rectangle(2, 3);

                int actual = rectangle.SetLength(2);
                int expected = 2;
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest6
        {
            [Test]
            public void RectangleLength_Input10()
            {
                Rectangle rectangle = new Rectangle(10, 30);

                int actual = rectangle.SetLength(10);
                int expected = 10;
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest7
        {
            [Test]


            public void RectangleWidth_Input6()
            {
                Rectangle rectangle = new Rectangle(3, 6);
                int expected = 6;
                int actual = rectangle.GetWidth();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest8
        {
            [Test]


            public void RectangleWidth_Input10()
            {
                Rectangle rectangle = new Rectangle(7, 10);
                int expected = 10;
                int actual = rectangle.GetWidth();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest9
        {
            [Test]


            public void RectangleWidth_Input5()
            {
                Rectangle rectangle = new Rectangle(2, 5);
                int expected = 5;
                int actual = rectangle.GetWidth();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest10
        {
            [Test]
            public void RectangleWidth_Input10()
            {
                Rectangle rectangle = new Rectangle(5, 10);

                int actual = rectangle.SetWidth(10);
                int expected = 10;
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest11
        {
            [Test]
            public void RectangleWidth_Input3()
            {
                Rectangle rectangle = new Rectangle(2, 3);

                int actual = rectangle.SetWidth(3);
                int expected = 3;
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest12
        {
            [Test]
            public void RectangleWidth_Input10()
            {
                Rectangle rectangle = new Rectangle(10, 30);

                int actual = rectangle.SetWidth(30);
                int expected = 30;
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest13
        {
            [Test]
            public void RectanglePerimeter()
            {
                Rectangle rectangle = new Rectangle(7, 10);
                int expected = 34;
                int actual = rectangle.GetPerimeter();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest14
        {
            [Test]


            public void RectanglePerimeter()
            {
                Rectangle rectangle = new Rectangle(3, 6);
                int expected = 18;
                int actual = rectangle.GetPerimeter();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest15
        {
            [Test]


            public void RectanglePerimeter()
            {
                Rectangle rectangle = new Rectangle(2, 5);
                int expected = 14;
                int actual = rectangle.GetPerimeter();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest16
        {
            [Test]
            public void RectangleArea()
            {
                Rectangle rectangle = new Rectangle(7, 10);
                int expected = 70;
                int actual = rectangle.GetArea();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest17
        {
            [Test]


            public void RectangleArea()
            {
                Rectangle rectangle = new Rectangle(3, 6);
                int expected = 18;
                int actual = rectangle.GetArea();
                Assert.AreEqual(expected, actual);
            }
        }
        public class RectangleTest18
        {
            [Test]


            public void RectangleArea()
            {
                Rectangle rectangle = new Rectangle(2, 5);
                int expected = 10;
                int actual = rectangle.GetArea();
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
