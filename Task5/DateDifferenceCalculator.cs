using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class DateDifferenceCalculator
    {

        public static void GetDifference(DateTime startDate, DateTime endDate)
        {
            if (endDate < startDate)
            {
                DateTime temp = startDate;
                startDate = endDate;
                endDate = temp;
            }

            int years = endDate.Year - startDate.Year;
            int months = endDate.Month - startDate.Month;
            int days = endDate.Day - startDate.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(startDate.Year, startDate.Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            Console.WriteLine($"Difference: {years} years, {months} months, {days} days.");
        }
    }
}
