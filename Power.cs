using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Power
    {
        public static void Exponent()
        {
            Console.WriteLine("Enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            if (n >= 0 && n < 31)
            {
                Console.WriteLine("Power of 2 until " + n);
                int pow = 1;
                for (int i = 1; i <= n; i++)
                {
                    pow = pow * 2;
                    Console.WriteLine(pow);
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
