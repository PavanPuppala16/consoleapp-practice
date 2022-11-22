using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    class tabless
    {
        public void tables()
        {
            int i, n;
            Console.WriteLine("enter n value");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<=10;i++)
            {
                Console.WriteLine("{0}*{1}={2}", +i, +n, i * n);
            }

        }
    }
    class UpperToLower
    {
        public void converting()
        {
            string str;
            Console.WriteLine("enter the string ");
            str = Console.ReadLine();
            //------ converting 
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str.ToUpper());

        }

    }



    internal class Table
    {
    }
}
