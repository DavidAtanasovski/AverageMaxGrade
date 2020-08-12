using cSharp_1.GradeBook;
using System;

namespace cSharp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(3);
            book.AddGrade(5);
            book.AddGrade(7);
            book.AddGrade(9);
            book.AddGrade(11);

            var statistic = book.ComputeAverageMaxGrade();
            Console.WriteLine($"Average: {statistic.Avarage:N4}");
            Console.WriteLine($"Max Number: {statistic.MaxNumber}");
        }
    }

}