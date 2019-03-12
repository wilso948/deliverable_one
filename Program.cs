using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Format_Correct_Complete
{
    class Program
    {
        static void Main(string[] args)

        {
            double amount1 = 0;
            double amount2 = 0;
            double amount3 = 0;


            Console.WriteLine("Please enter amount 1:");
            amount1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter amount 2:");
            amount2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Please enter amount 3:");
            amount3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(("The average amount is $") + string.Format("{0:#.00}", Convert.ToDecimal(amount1 + amount2 + amount3) / 3));
            Console.WriteLine("Press any key for the next result");
            Console.ReadKey();




            double[] myArray = new[] { amount1, amount2, amount3 };

            double highest = myArray.Max();

            Console.WriteLine(($"The highest amount you entered is ") + (highest));
            Console.ReadKey();


            double[] myArray2 = new[] { amount1, amount2, amount3 };

            double lowest = myArray.Min();

            Console.WriteLine(($"The lowest amount you entered is ") + (lowest));
            Console.ReadKey();



            double value = amount1 + amount2 + amount3;

            Console.WriteLine("The total in USD is:");
            Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
            Console.ReadKey();

            Console.WriteLine("The total in SEK is:");
            Console.WriteLine(value.ToString("C2", CultureInfo.CreateSpecificCulture("da-DK")));
            Console.ReadKey();

            Console.WriteLine("The total in JPY is:");
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.ReadKey();

            Console.WriteLine("The total in THB is:");
            Console.WriteLine(value.ToString("C2", CultureInfo.CreateSpecificCulture("ta-THB")));
            Console.ReadKey();

            Console.WriteLine("Thank you for attending my Ted Talk.");
            Console.ReadKey();



















            Console.ReadKey();





        }
    }
}










