namespace Task3_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1-	Correct the syntax error:

                •	string [ ] ARR= [ 1,7  9  45, ]
                •	int arr2=["Str" "alex","moh"
                •	string arr3= 'the','fox' 'over' lazy, 'dog',  ]     
             
             */

            int[] ARR = { 1, 7, 9, 45 };
            string[] arr2 = { "Str", "alex", "moh" };
            string[] arr3 = { "the", "fox", "over", "lazy", "dog" };


            /*
                2-	What the index of "Banana","Tomato"?
                String [ ]  fruits=["Tomato","Banana","Watermelon"]
            The index of Banana = 1
            The index of Tomato = 0
             
             */

            /*  3  */
            string[] food = { "Mansaf", "Kabseh", "Maqlubh", "Falafel", "Shawrmah" };
            string[] Sport = { "Football", "BasketBall", "VollyBall" };
            string[] movie = { "OnePice", "Naruto", "Akami ga kill", "Demon Slayer" };


            /* 4 */
            //Console.WriteLine("Please enter 3 number: ");
            //string numbers = Console.ReadLine();
            //string[] arrayOfNumbers = numbers.Split(',');
            //int sum = 0;
            //foreach (string number in arrayOfNumbers) {
            //    sum += Convert.ToInt32(numbers.Trim());
            //}
            //Console.WriteLine(sum);


            /*  5  */

            int sumOfOddNum = 0;
            for (int i = 1; i < 100; i += 2)
            {
                Console.Write(i + " ");
                sumOfOddNum += i;
            }
            Console.WriteLine();
            Console.WriteLine(sumOfOddNum);


            /*  5  */

            int x = 3;
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /*  6  */


            int rows = 4;
            int number = 1;

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
    }
}
