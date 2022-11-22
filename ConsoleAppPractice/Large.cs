using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{

    class  factorial
    {







        public void fact()
            {
            int i, n,sum=0;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (i=1;i<n;i++)
            {
                sum = sum * i;
            }
            Console.WriteLine(sum);



        }


    }
    class LeapYear
    {
        public void Positive()
        {
            int n1;
            Console.WriteLine("enter the number1");
            n1 = Convert.ToInt32(Console.ReadLine());
            if(n1>0)
            {
                Console.WriteLine("it is positive");
            }
            else
            {
                Console.WriteLine("it is negative");
            }
        }

        public void Year()
        {

            int year;
            Console.WriteLine("enter the year");
            year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                if(year%100==0)
                {
                    Console.WriteLine("it is leapyear");
                }
                else
                {
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("it is not  leapyear");
            }
        }
    }
    internal class Large
    {
        
        public void Largeest()
        {
            int n1,n2,n3;
            Console.WriteLine("enter the number1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number13");
            n3 = Convert.ToInt32(Console.ReadLine());
            if(n1>n2&& n1>n3)
            {
                Console.WriteLine("n1 is greate");

            }
            else if(n2>n3 && n2>n1)
            {
                Console.WriteLine("n2 is greate");

            }
            else
            {
                Console.WriteLine("n3 is greate");

            }
           
          
        }
    }
}
