namespace Task4_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  1   */
            SumArray.SummationAndAVG([1, 3, 5, 7, 3, 9, 7, 3, 22, 4]);

            /*  2  */
            Console.WriteLine("Enter a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            cube.CalculateCube(n);


            /*    3    */
            int[] years = {1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020};
            Years.Year(years);

            /*   4     */

            static int ConvertYearsToDays(int years)
            {
                return years * 365; // Not accounting for leap years
            }

            Console.Write("Enter your age in years: ");
            int ageInYears = int.Parse(Console.ReadLine());
            int ageInDays = ConvertYearsToDays(ageInYears);
            Console.WriteLine("Your age in days is: " + ageInDays);


            /*   5    */


            static int CalculateTotalLegs(int chickens, int cows, int pigs)
            {
                // Validate input to ensure no negative numbers
                if (chickens < 0 || cows < 0 || pigs < 0)
                {
                    throw new ArgumentException("The number of animals cannot be negative.");
                }

                int chickenLegs = chickens * 2;
                int cowLegs = cows * 4;
                int pigLegs = pigs * 4;

                return chickenLegs + cowLegs + pigLegs;
            }

            Console.WriteLine("Total legs: " + CalculateTotalLegs(2, 3, 5));


            /*    6    */
            static void Login(string username , string pass)
            {
                string userName = "Mutasem";
                string Pass = "mutasem123";
                if(username != userName && pass != Pass)
                {
                    Console.WriteLine("Log in faild");
                }
                else
                {
                    Console.WriteLine("Log in Succsessfully");
                }
            }
            Login("Mutasem", "mutasem123");


            /*    7    */

            static void calcPow(int n, int p)
            {
                Console.WriteLine(Math.Pow(n,p));
            }
            calcPow(3, 2);

            /*    7    */

            static string IsLeapYear(int year)
            {
                if (year < 1900 || year > 2024)
                {
                    return "Year out of range. Please enter a year between 1900 and 2024.";
                }
                if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    return $"{year} is a leap year.";
                }
                else
                {
                    return $"{year} is not a leap year.";
                }
            }

            Console.WriteLine("Enter a year between 1900 and 2024:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine(IsLeapYear(year));


            /*    7    */

            static bool isPrime(int n)
            {
                for (int i = 2; i < Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }


                }
                return true;

            }

            isPrime(5);

            /*    8    */


            static void countWord(string word)
            {
                string[] arr = word.Split(' ');
                Console.WriteLine(arr.Length);
            }
            countWord("Mutasem Ai Shboul");



        }
    }
}
