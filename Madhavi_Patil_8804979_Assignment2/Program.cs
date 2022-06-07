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
            // Initializing input value for length of rectangle
            int input = 0;
            Console.WriteLine("Please enter the length of the rectangle: ");
            string strl = Console.ReadLine();
            int l;
           
            while (!int.TryParse(strl, out l) || int.Parse(strl) == 0)
            {
                Console.WriteLine("Please Enter a valid integer value!");
                strl = Console.ReadLine();
                
            }
            l = int.Parse(strl);

            // Initializing input value for width of rectangle
            Console.WriteLine("Please enter the width of the rectangle: ");
            string strw = Console.ReadLine();
            int w;
          
            while (!int.TryParse(strw, out w) || int.Parse(strw) == 0)
            {
                Console.WriteLine("Please Enter a valid integer value!");
                strw = Console.ReadLine();
            }
            w = int.Parse(strw);

            //Looping through all menu options
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
           // ShowMenu();


        }
        //function for displaying menu to user
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

            int m;
            string menu = Console.ReadLine();
            while(!int.TryParse(menu, out m ) || int.Parse(menu) > 7)
            {
                Console.WriteLine("Choose option from Menu!!!");
                menu = Console.ReadLine();  
            }

            return int.Parse(menu);
        }
    }

   
}
