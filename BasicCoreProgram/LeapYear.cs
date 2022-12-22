using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LeapYear
    {
        public void Check()
        {
            Console.WriteLine("Enter the year to check");
            int Year=Convert.ToInt32(Console.ReadLine());
            if (Year % 4 == 0 && Year % 100 != 0)

                Console.WriteLine("{0} is Leap year",Year);
            else
                Console.WriteLine("{0} is Not a leap year",Year);
            
        }
    }
}
