using System;

namespace LineCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to Line Comparision Computation Program");
            //Getting inputs
            int x1, y1, x2, y2, x3, y3, x4, y4;
            //Geeting inputs for both the points of line 1
            Console.WriteLine("Enter values of x1 and y1 for line 1 : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values of x2 and y2 for line 1 : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            //Geeting inputs for both the points of line 2
            Console.WriteLine("Enter values of x1 and y1 for line 2 : ");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter values of x2 and y2 for line 2 : ");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
