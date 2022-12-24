using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class VowelConsonant
    {
        public void Vowel()
        {
            Console.WriteLine("Enter the alphabet you want to check");
            char ch = Convert.ToChar(Console.ReadLine().ToLower());
            switch (ch)
            {
                case 'a':
                case 'i':
                case 'o':
                case 'u':
                case 'e':
                    Console.WriteLine("Entered alphabet is a vowel");
                    break;
                default:
                    Console.WriteLine("Entered alphabet is a consonant");
                    break;
            }
        }
    }
}
