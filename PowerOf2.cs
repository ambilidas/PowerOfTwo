using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    internal class PowerOf2
    {
        public void tableOfPower2()
        {
            Console.WriteLine("Enter the limit N(should be with in 0<=N<31) ");
            int N=Convert.ToInt32(Console.ReadLine());
            int p=1;
            Console.WriteLine("Powers of Two");
            for (int i = 0; i <= N; i++)
            {
                if (i == 0)
                {
                    p = 1;
                    
                }
                else
                {
                    p = p * 2;
                   
                }
                Console.WriteLine("2^{0} = {1}",i,p);
            }

        }
    }
}
