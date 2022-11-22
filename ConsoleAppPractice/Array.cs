using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{
    internal class Array
    {
        public void ArrayReverse()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.Write("enter no.of enelemts in array");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
                
            }
            for(int i=n-1;i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }

           
        }

        public void my()
        {
            int[] a = { 1, 2, 3, 4 };
            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(a[i]);
            }
            for(int i=a.Length-1;i>=0;i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
