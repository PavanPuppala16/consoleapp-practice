using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class Amstrong
    {

        public  void me()
        {
            int sum, i, j, temp,n;
            sum = 0;
           
            Console.WriteLine("enter a number");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                j = n % 10;
                sum = sum + (j * j * j);
                n = n /10;

            }
            if(temp==sum)
            {
                Console.WriteLine("given number is amstrong");

            }
            else
            {

                Console.WriteLine("it is not a amstrong number");
            
            }
        }
    }
}
