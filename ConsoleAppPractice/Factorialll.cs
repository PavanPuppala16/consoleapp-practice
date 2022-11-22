using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{

    class factoriall
    {

        public int fact(int n)
        {
            Console.WriteLine("enter number ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
                return 1;
            return n * fact(n - 1);
        }
        public  void Facto()
        {
            int n;
            int result=1;
            Console.WriteLine("enter number ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine(1);

               

            }
            else
            {
                for (int i = 1; i <=n; i++)
                {
                    result = result * i;

                }
                Console.WriteLine(result);
                Console.ReadLine();
            }
               
        }
    }
    internal class Factorialll
    {
    }
}
