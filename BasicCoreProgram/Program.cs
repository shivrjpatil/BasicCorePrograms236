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
            Console.WriteLine("1.FlipCoin \n2.LeapYear\n3.Powere of Two\n4.Harmonic Number\n5.Prime Factor");
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
                case 3:
                    PowerofTwo powerofTwo= new PowerofTwo();
                    powerofTwo.Power();
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.Harmonic();
                    break;
                case 5:
                    PrimeFactors primeFactors = new PrimeFactors();
                    primeFactors.Factor();
                    break;
            }
            Console.ReadLine();
        }
    }
}
