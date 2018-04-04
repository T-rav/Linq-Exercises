using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution
{
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
