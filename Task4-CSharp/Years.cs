using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task4_CSharp
{
    public class Years
    {
        
        public static void Year(int[] arr)
        {
            foreach (int i in arr)
            {
                if(i> 1950)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
