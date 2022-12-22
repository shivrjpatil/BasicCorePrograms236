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
            Console.WriteLine("1.FlipCoin \n 2.LeapYear");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                     FlipCoin flipCoin = new FlipCoin();
                     flipCoin.FindPercentage();
                    break;
                case 2:
                     LeapYear leap = new LeapYear();
                     leap.Check();
                    break;
            }
            Console.ReadLine();
        }
    }
}
