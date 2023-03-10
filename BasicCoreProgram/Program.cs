using Microsoft.Win32.SafeHandles;
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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("welcome to c# Basic core Programs");
                Console.WriteLine("1.FlipCoin \n2.LeapYear\n3.Powere of Two\n4.Harmonic Number\n5.Prime Factor\n6.Quotient and Reaminder\n7.Swap Two Numbers\n8.Check Even Odd\n9.Vowel or Consonant\n10.Largest among Three Numbers");
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
                        PowerofTwo powerofTwo = new PowerofTwo();
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
                    case 6:
                        QuotientRemainder quotientRemainder = new QuotientRemainder();
                        quotientRemainder.Div();
                        break;
                    case 7:
                        SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                        swapTwoNumbers.Swap();
                        break;
                    case 8:
                        EvenOdd evenOdd = new EvenOdd();
                        evenOdd.Check();
                        break;
                    case 9:
                        VowelConsonant vowelConsonant = new VowelConsonant();
                        vowelConsonant.Vowel();
                        break;
                    case 10:
                        LargestNumber largestNumber = new LargestNumber();
                        largestNumber.Largest();
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
