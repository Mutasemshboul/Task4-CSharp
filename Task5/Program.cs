using System.Globalization;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*   1   */
            MyClass myClass = new MyClass();


            /*   2   */
            static void DisplayGreeting(string name)
            {
                Console.WriteLine($"Hello All, I am {name}");
            }
            DisplayGreeting("Scott");

            /*   3   */


            static void factorial(int n)
            {
                int c = 1;
                for (int i = n; i >= 1; i++)
                {
                    c *= i;
                    c--;
                }
            }

            factorial(4);

            /*   4   */

            int[] array = { 11, -2, 4, 35, 0, 8, -9 };
            Array.Sort(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }


            /*   5   */

            DateTime date1 = new DateTime(1981, 11, 03);
            DateTime date2 = new DateTime(2013, 09, 04);
            DateDifferenceCalculator.GetDifference(date1, date2);



            /*   6   */

            string dateString = "12-08-2004";
            string format = "dd-MM-yyyy";

            DateTime dateValue = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);

            Console.WriteLine("Converted Date: " + dateValue.ToString("yyyy-MM-dd"));
        }
    }
}
