using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class PrimeFactors
    {
        public void Prime(int n)
        {
            while (n % 2 == 0)
            {
                Console.Write(2 + " ");
                n /= 2;
            }
            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + "");
                    n /= i;
                }
            }
            if (n > 2)
                Console.Write(n);
        }
        public void Factor()
        {
            Console.WriteLine("Enter the number for which you want to find prime factors");
            int primeNum = Convert.ToInt32(Console.ReadLine());
            Prime(primeNum);
        }
    }
}
