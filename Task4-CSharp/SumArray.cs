using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_CSharp
{
    public class SumArray
    {
        public static void SummationAndAVG(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            Console.WriteLine("The summation is : "+sum);
            Console.WriteLine("The AVG is : "+sum/array.Length);
        }
    }
}
