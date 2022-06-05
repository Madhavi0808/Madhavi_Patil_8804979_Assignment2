using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madhavi_Patil_8804979_Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            Console.WriteLine("Please enter the length of the rectangle: ");
            int l;
            while (!int.TryParse(Console.ReadLine(), out l))
            {
                Console.WriteLine("Please Enter a valid integer value!");

            }


            Console.WriteLine("Please enter the width of the rectangle: ");
            int w;
            while (!int.TryParse(Console.ReadLine(), out w))
            {
                Console.WriteLine("Please Enter a valid integer value!");

            }

            do
            {
                input = ShowMenu();
                Rectangle r = new Rectangle();
              
                r.SetLength(l);
                r.GetWidth();
                r.SetWidth(w);
                if (input == 1)
                {
                   Console.Write("The length of rectangle is: ");
                    Console.WriteLine(r.GetLength());
                }
                else if (input == 2)
                {
                    Console.Write("Please enter the length of the rectangle: ");
                    while (!int.TryParse(Console.ReadLine(), out l))
                    {
                        Console.WriteLine("Please Enter a valid integer value!");

                    }
                    Console.ReadLine();
                }
                else if (input == 3)
                {
                    Console.Write("The width of rectangle is: ");
                    Console.WriteLine(r.GetWidth());
                }
                else if (input == 4)
                {
                    Console.Write("Please enter the width of the rectangle: ");
                    while (!int.TryParse(Console.ReadLine(), out w))
                    {
                        Console.WriteLine("Please Enter a valid integer value!");

                    }
                    Console.ReadLine();
                }
                else if (input == 5)
                {
                    Console.Write("The perimeter of rectangle is: ");
                    Console.WriteLine(r.GetPerimeter());
                }
                else if (input == 6)
                {
                    Console.Write("The area of rectangle is: ");
                    Console.WriteLine(r.GetArea());
                }
                else if (input == 7)
                {
                    Environment.Exit(0);
                }
            }
            while (input < 7);
            Console.WriteLine("Enter valid option");
            ShowMenu();


        }
        public static int ShowMenu()
        {
            Console.Write("\n\n");
            Console.Write("---------------------------Menu-------------------------\n");
            Console.Write("1. Get Rectangle Length\n");
            Console.Write("2. Change Rectangle Length\n");
            Console.Write("3. Get Rectangle Width\n");
            Console.Write("4. Change Rectangle Width\n");
            Console.Write("5. Get Rectangle Perimeter\n");
            Console.Write("6. Get Rectangle Area\n");
            Console.Write("7. Exit\n");

            return int.Parse(Console.ReadLine());
        }
    }

   
}
