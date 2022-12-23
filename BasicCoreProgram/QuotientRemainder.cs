using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class QuotientRemainder
    {
        public void Div()
        {
            Console.WriteLine("enter divider and divendant");
            int A=Convert.ToInt32(Console.ReadLine());
            int B=Convert.ToInt32(Console.ReadLine());
            
            int Quotient = A / B;
            int Remainder = A % B;
            Console.WriteLine("Quotient and Remaindeer of given number is= "+Quotient );
            Console.WriteLine("Reaminder of given number is="+Remainder);
        }
    }
}
