using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppPractice
{
    class XPowerY
    {

        public long power(int n, int p)
        {

            //Console.WriteLine("enter the number");
            //n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the number");
            //p = Convert.ToInt32(Console.ReadLine());
            long res;
            res = power(n, p);
            Console.WriteLine(res);
            if (p != 0)
            {
                return (n * power(n, p - 1));
            }
            return 1;

        }
    }
        class SumofNumber
        {
            public void number()

            {
                int n, sum = 0;
                Console.WriteLine("enter number");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 0)
                {
                    Console.WriteLine(0);

                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        sum = sum + (n * (n - 1) / 2);
                    }
                    Console.WriteLine(sum);
                    Console.ReadLine();
                }

            }
        }


        class Squre
        {
            public void SquresofNumber()
            {
                int i, n, sum = 0;
                Console.WriteLine("value of squre of a number");
                Console.WriteLine("_____________");

                Console.WriteLine("enter a number");
                n = Convert.ToInt32(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    for (i = 0; i < n; i++)
                    {
                        sum = sum + (n * n);
                    }
                }
                Console.WriteLine(sum);
                Console.ReadLine();

            }
        }
        internal class SumofN
        {
        }
    
}
