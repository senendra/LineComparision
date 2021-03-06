﻿using System;

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
            //Checking 2 lines are equal or not
            double line1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double line2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            //Comparing both the line to get difference in length
            int difflnLength = line1.CompareTo(line2);
            if(difflnLength == 0)
            {
                Console.WriteLine("Lines are equal");
            }
            else if (difflnLength > 0)
            {
                Console.WriteLine("Line 1 is greater in length than line 2");
            }
            else 
            {
                Console.WriteLine("Line 2 is greater in length than line 1");
            }

        }
    }
}
