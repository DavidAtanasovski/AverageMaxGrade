using System;
using System.Collections.Generic;

namespace cSharp_1.GradeBook
{
    class Book
    {
        
        private List<int> grades;

        public Book()
        {
            grades = new List<int>();
        }

        public void AddGrade(int grade)
        {
            if (grade > 0)
            {
                grades.Add(grade);
            }
        }

        public Statistic ComputeAverageMaxGrade()
        {
            var result = 0.0;
            var maxNumber = int.MinValue;
            foreach (var number in grades)
            {
                result += number;
                maxNumber = Math.Max(maxNumber, number);
            }

            result /= grades.Count;

            var statistics = new Statistic();
            statistics.Avarage = result;
            statistics.MaxNumber = maxNumber;

            return statistics;
        }
    }
}
