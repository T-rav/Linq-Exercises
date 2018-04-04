using System;
using System.Collections.Generic;
using System.Linq;

namespace Solution
{
    public class LinqExercises
    {
        public void NumberTimeFrequency(IEnumerable<int> frequencyNumbers)
        {
            var numberFrequenceMatrix = from number in frequencyNumbers
                group number by number
                into frequenceyMatrix
                select new
                {
                    Number = frequenceyMatrix.First(),
                    NumberTimesFrequency = frequenceyMatrix.Count() * frequenceyMatrix.First(),
                    Frequency = frequenceyMatrix.Count()
                };

            foreach (var number in numberFrequenceMatrix)
            {
                Console.WriteLine($"{number}");
            }
        }

        public void NumbersWhoSquareIsGreaterThan20(IEnumerable<int> numbers)
        {
            var squares = from number in numbers
                where number * number > 20
                select new {Number = number, Square = number * number};

            Console.WriteLine("Numbers who's square is greater than 20:");
            foreach (var square in squares)
            {
                Console.WriteLine($"{square}");
            }
        }

        public void NumbersDivisibleBy2(IEnumerable<int> numbers)
        {
            var divisibleBy2 = GetNumbersDivisibleBy2(numbers);
            var print = string.Join(",", divisibleBy2);

            Console.WriteLine($"Numbers divisible by 2 => {print}");
        }

        private IEnumerable<int> GetNumbersDivisibleBy2(IEnumerable<int> numbers)
        {
            var numbersDivisibleBy2 = from number in numbers
                where number % 2 == 0
                select number;

            return numbersDivisibleBy2;
        }
    }
}