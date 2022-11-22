using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    class ascii
    {
        public void asscivalue()
            {
            string pavan = "ABCDEFGH";
            foreach(var c in pavan)
            {
                Console.WriteLine((int)c);
            }

        }
    }



    internal class Area
    {

        public void AreaTraingel()
        {
            float b, h ;
            Console.WriteLine("enter b value");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter h value");
            h = Convert.ToSingle(Console.ReadLine());
           double area = (b * h) / 2;
           
            Console.WriteLine(area);


        }
    }
}
