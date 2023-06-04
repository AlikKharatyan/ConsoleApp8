using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int result3=1;
            int result1 = 10;
            int result2 = 1;
            for (int i = 50; i <= 70; i++)
            {
                if (i % 2 == 0)
                {
                    result1 = i/2;

                }
                else
                {
                    result2 =((i*3)+1)/2;
                    if (result2 % 2 == 0)
                    {
                        result3 = result2 / 2;
                        
                    }
                }
            }
            Console.WriteLine(result3);
            Console.WriteLine(result1);
           
            
        }
    }
}
