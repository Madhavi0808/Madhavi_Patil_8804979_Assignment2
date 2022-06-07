using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
//using NUnitDemonstration;


namespace Madhavi_Patil_8804979_Assignment2.Tests
{
    public class RectangleTest
    {
        [TestFixture]

        public class RectangleTest1
        {
            [Test]
            
            
            public void RectangleLength_Input3()
            {
               
                Rectangle rect = new Rectangle();
                string expected = "The length of rectangle is 3";

                int actual = rect.GetLength();

                Assert.AreEqual(expected, actual);


            }
        }
       // static void Main(string[] args)
        //{
        //}
    }
}
