using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class SwapTwoNumbers
    {
        public void Swap()
        {
            Console.WriteLine("Enter the two numbers");
            int A=Convert.ToInt32(Console.ReadLine());
            int B=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swaping A={0} and B={1}", A, B);
            int temp = 0;
            temp = A;
            A = B;
            B= temp;    
            Console.WriteLine("after swaping A={0} B={1} numbers ",A,B);
        }
    }
}
