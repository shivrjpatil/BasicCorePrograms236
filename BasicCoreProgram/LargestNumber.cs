using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class LargestNumber
    {
        public void Largest()
        {
            Console.WriteLine("Enter the first number");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            int third = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
                Console.WriteLine("{0} is the largest number among all three", first);
            else if (second > first && second > third)
                Console.WriteLine("{0} is the largest number among all three", second);
            else
                Console.WriteLine("{0} is the largest number among all three", third);
        }
    }
}
