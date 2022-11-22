using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPractice
{

    public class Star
    {
        public void printstar()
        {
            int n;
            Console.Write("Enter the range: ");
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                
                Console.Write("*"+"\t");
                for(int j=0;j<i-1;j++)
                {
                    Console.WriteLine("#");

                }
            }

            Console.WriteLine("\n");
        }
    }

    public class Date
    {
        public void calldate()
        {
            var prevDate = new DateTime(2021, 7, 15); //15 July 2021
            var today = DateTime.Now;

            Console.WriteLine("prevDate: {0}", prevDate);
            Console.WriteLine("today: {0}", today);

            //get difference of two dates
            var diffOfDates = today - prevDate;
            Console.WriteLine("Difference in Timespan: {0}", diffOfDates);
            Console.WriteLine("Difference in Days: {0}", diffOfDates.Days);
            Console.WriteLine("Difference in Hours: {0}", diffOfDates.Hours);
            Console.WriteLine("Difference in Miniutes: {0}", diffOfDates.Minutes);
            Console.WriteLine("Difference in Seconds: {0}", diffOfDates.Seconds);
            Console.WriteLine("Difference in Milliseconds: {0}", diffOfDates.Milliseconds);
            Console.WriteLine("Difference in Ticks: {0}", diffOfDates.Ticks);
        }
        public void Dates()
        {
            DateTime date1 = new DateTime(2018, 8, 27);
            DateTime date2 = new DateTime(2018, 8, 28);

            // getting the difference
            TimeSpan t = date2.Subtract(date1);

            Console.WriteLine(t);
            Console.WriteLine("Days (Difference) = {0} ", t.TotalDays);
            Console.WriteLine("Minutes (Difference) = {0}", t.TotalMinutes);

        }
    }
  
    public  class fabaonic
    {
        public  int Traingelsiris()
        {

            int x = 1, y = 2, i, z, num, j;
            Console.Write("Enter the range: ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
            {
                x = 0;
                y = 1;
                Console.Write(y + "\t");
                for (j = 1; j < i; j++)
                {
                    z = x + y;
                    Console.Write(z + "\t");
                    x = y;
                    y = z;
                }
                Console.Write("\n");
            }
        
            return 1;
        }

        public void Series()
        {
            int x=0, y=1,z;
            Console.WriteLine("enter n value");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n; i++)
            {
                z = x + y;
                x = y;
                y = z;
                Console.WriteLine(z);
            }


        }
       


    }


    internal class FacbanoicTraingle
    {
    }
}
