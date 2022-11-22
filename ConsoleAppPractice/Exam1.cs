using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{

    class first
    {
        static  first()
        {
            string myname, rev;
            myname = "pavan";
            rev = "";
            Console.WriteLine( myname);
            int len;
            len = myname.Length - 1;
            while (len >= 0)
            {
                rev = rev + myname[len];
                len--;
               
            }
            Console.WriteLine("Reversed String is {0}", rev);
        }
    }

    class sum
    {
        public  void sum1()
        {
            int i=10, j=10;
            int sum = i + j;
            Console.WriteLine(sum);
          

            
        }
    }


   
    class array
    {
        public void reversArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine("array elements");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + "");
            }
          
    }
        
    }
    
    internal class Exam1
    {
       public   void merr() 
        {
        int i, n;
        int[] a = new int[100];

        Console.Write("\n\nRead n number of values in an array and display it in reverse order:\n");
       Console.Write("------------------------------------------------------------------------\n");
   
   Console.Write("Input the number of elements to store in the array :");
   n = Convert.ToInt32(Console.ReadLine());    
   
   
   Console.Write("Input {0} number of elements in the array :\n",n);
   for(i=0;i<n;i++)
      {
	  Console.Write("element - {0} : ",i);
	  a[i] = Convert.ToInt32(Console.ReadLine()); 
	  }

    Console.Write("\nThe values store into the array are : \n");
   for(i=0;i<n;i++)
     {
	   Console.Write("{0}  ",a[i]);
	 }

Console.Write("\n\nThe values store into the array in reverse are :\n");
for (i = n - 1; i >= 0; i--)
{
    Console.Write("{0} ", a[i]);
}
Console.Write("\n\n");
  } 


    }
}
