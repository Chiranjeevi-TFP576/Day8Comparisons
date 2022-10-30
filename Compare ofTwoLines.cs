using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDemo
{
    internal class Compare_ofTwoLines
    {
        public static void ComparedTwoLines()
        {
            Console.WriteLine("enter the coordinates of first line");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int LengthOfLine1 = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("enter the coordinates of Second line");
            int x3 = Convert.ToInt32(Console.ReadLine());
            int y3 = Convert.ToInt32(Console.ReadLine());
            int x4 = Convert.ToInt32(Console.ReadLine());
            int y4 = Convert.ToInt32(Console.ReadLine());
            int LengthOfLine2 = (int)Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
            if(LengthOfLine1 > LengthOfLine2)
            {
                Console.WriteLine("Line1 is greater");
            }
            else
            {
                Console.WriteLine("Line2 is greater");
            }
        }
    }
}
