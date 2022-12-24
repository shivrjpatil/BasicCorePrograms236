using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class EvenOdd
    {
       public void Check()
        {
            Console.WriteLine("Enter the Number");
            int num=Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("The number is even");
            else
                Console.WriteLine("the number is odd");
        }
    }
}
