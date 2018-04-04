using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
    /*
       > Write a program that uses LINQ to find all numbers between 0-9 which are divisible by 2.
       > Write a program that uses LINQ to find all numbers 0-9 whose square is more than 20. Print the
       number and its square. E.g. { Number = 9, Square=81 }
       > Write a program to display numbers, multiplication of number with frequency and the frequency
       of the number given a collection of numbers.
     */
    class Program
    {
        static void Main(string[] args)
        {
            var exercies = new LinqExercises();
            Console.WriteLine("For numbers 0-9...");
            var numbers = Enumerable.Range(0, 10);

            exercies.NumbersDivisibleBy2(numbers);
            exercies.NumbersWhoSquareIsGreaterThan20(numbers);

            var frequencyNumbers = new int[] {1, 2, 2, 5, 5, 5, 1, 33, 33, 7, 8, 9, 9};
            var print = string.Join(",", frequencyNumbers);

            Console.WriteLine("");
            Console.WriteLine($"Numbers and their frequency for {print}...");

            exercies.NumberTimeFrequency(frequencyNumbers);

            Console.ReadLine();
        }
    }
}
