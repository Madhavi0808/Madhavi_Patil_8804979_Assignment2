using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madhavi_Patil_8804979_Assignment2
{
    public class Rectangle
    {
        //private integer  attributes
        private int length { get; set; }
        private int width { get; set; }

        //default constructor
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        //non-default constructor
        public Rectangle(int x, int y)
        {
            length = x;
            width = y;
        }

        //methods
        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        public int GetPerimeter()
        {
            int perimeter = 2*(length+width);  
            return perimeter;
        }

        public int GetArea()
        {
            int area = length*width;
            return area;
        }

    }
}
