using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());

            Console.WriteLine(myValue.ToShortTimeString());

           Console.WriteLine(myValue.AddDays(3).ToLongDateString());

            DateTime myBirthday = DateTime.Parse("20/12/1987");
            TimeSpan muAge = DateTime.Now.Subtract(myBirthday);
            Console.WriteLine(muAge.TotalDays);

            Console.ReadLine();
        }
    }
}
