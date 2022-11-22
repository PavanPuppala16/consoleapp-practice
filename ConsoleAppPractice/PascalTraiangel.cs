using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{


    class triangel
    {
        public void pascal()
            {
            int i, j, n,blank,c=1;
            Console.WriteLine("enter the no.of rows");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                for(blank=0;blank<n-i;blank++)
                {
                    Console.Write("  ");
                    for (j=0;j<i;j++)
                    {
                        if(i==0||j==0)
                        {
                            c = 1;


                        }
                        else
                        {
                            c = c *(i - j + 1) / j;
                            Console.WriteLine(c);
                        }

                      
                    }
                }
            }
        }
    }
    internal class PascalTraiangel
    {
    }
}
