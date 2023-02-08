using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class LeapYear
    {
        public static void IsLeapYear()
        {
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            bool leap = false;
            if (year % 400 == 0)
            {
                leap = true;
            }
            else if (year % 100 == 0)
            {
                leap = false;
            }
            else if (year % 4 == 0)
            {
                leap = true;
            }
            Console.WriteLine(leap);
        }
    }
}
