using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());

            var topStudents = 0;
            var fourToFive = 0;
            var threeToFour = 0;
            var lessThanThree = 0;
            var sumGrades = 0.0;

            for (int s = 0; s < students; s++)
            {
                var grade = double.Parse(Console.ReadLine());

                sumGrades += grade;

                if (grade >= 5)
                    topStudents++;
                else if (grade >= 4)
                    fourToFive++;
                else if (grade >= 3)
                    threeToFour++;
                else
                    lessThanThree++;
            }

            var averageGrade = sumGrades / students;
            Console.WriteLine("Top students: {0:f2}%", topStudents * 100.0 / students);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", fourToFive * 100.0 / students);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", threeToFour * 100.0 / students);
            Console.WriteLine("Fail: {0:f2}%", lessThanThree * 100.0 / students);
            Console.WriteLine("Average: {0:f2}", averageGrade);
        }
    }
}
