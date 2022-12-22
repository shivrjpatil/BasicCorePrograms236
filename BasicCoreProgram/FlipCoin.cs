using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class FlipCoin
    {
        public  void FindPercentage()
        {
            int Tailcount = 0, Headcount = 0;
            double Pecentage = 0;
            Console.WriteLine("enter the number of times coin need to be fliped");
            int num =Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < num; i++)
            {
                double input = random.NextDouble();
                if (input > 0.5)
                    Tailcount++;
                else
                    Headcount++;
            }
            Console.WriteLine("TailCount:{0} headcount:{1}",Tailcount,Headcount);
            double TailPercentage = (Tailcount * 100) / num;
            double HeadPercentage = (Headcount * 100) / num;
            Console.WriteLine("tail percenatge={0}% head percentage={1}%",TailPercentage, HeadPercentage);
        }
    }
}
