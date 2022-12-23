using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class PowerofTwo
    {
        public void Power()
        {
            Console.WriteLine("Enter the Number");
            int num =Convert.ToInt32(Console.ReadLine());   
            for (int i = 0; i <= num; i++)
            {
               Console.WriteLine("2^" +i+ "=" +Math.Pow(2, i));
            }
        }
    }
}
