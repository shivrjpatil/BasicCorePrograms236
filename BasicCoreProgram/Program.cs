using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to c# Basic core Programs");
            FlipCoin flipCoin=new FlipCoin();
            flipCoin.FindPercentage();
            
            Console.ReadLine();
        }
    }
}
