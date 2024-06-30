using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_CSharp
{
    public class cube
    {
        public static void CalculateCube(int n)
        {


            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Number is : {i} and cube of the {i} is : "+(i*i*i));
            }
        }
    }
}
