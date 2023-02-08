using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class FlipCoin
    {
        public static void Percentage()
        {
            System.Console.WriteLine("Enter the number of times the coin should be tossed");
            int head = 0;
            int tail = 0;
            int headcount = 0;
            int tailcount = 0;

            double headpercentage;
            double tailpercentage;

            int flipcoin = Convert.ToInt32(Console.ReadLine());

            if (flipcoin > 0)
            {
                for(int i=0; i<flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);

                    if (number == 0)
                    {
                        Console.WriteLine("Heads Won!");
                        headcount++;
                    }
                    else
                    {
                        Console.WriteLine("Tails Won!");
                        tailcount++;
                    }
                }
                headpercentage = headcount * 100 / flipcoin;
                tailpercentage = tailcount * 100 / flipcoin;

                Console.WriteLine("Head Percentage: "+ headpercentage + "%");
                Console.WriteLine("Tail Percentage: " + tailpercentage + "%");
            }
            else
            {
                Console.WriteLine("Enter a positive number");
            }
        }
    }
}
