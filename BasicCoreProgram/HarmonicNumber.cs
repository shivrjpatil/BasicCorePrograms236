using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class HarmonicNumber
    {
        float result = 0;
        public void Harmonic()
        {
            Console.WriteLine("enter the number ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <=num; i++)
            {
                 this.result +=(float) 1 / i;
            }
            Console.WriteLine("the sum of Nth harmonic series = "+result);
        }
    }
}
