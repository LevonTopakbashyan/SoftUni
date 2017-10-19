namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            var listOfStudents = new List<Student>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var input = Console.ReadLine().Split().ToList();

                var stundetsName = input[0];
                input.Remove(input[0]);
                var studentsGrades = input.Select(double.Parse).ToList();

                var newStudent = new Student
                {
                    Name = stundetsName,
                    Grade = studentsGrades
                };

                listOfStudents.Add(newStudent);
            }

            for (int i = 0; i < listOfStudents.Count; i++)
            {
                if (listOfStudents[i].AverageGrade <= 5.00)
                {
                    listOfStudents.Remove(listOfStudents[i]);
                }
            }

            var ordered = listOfStudents.
                OrderBy(x => x.Name).
                ThenBy(x => x.AverageGrade).
                ToList();

            foreach (var item in ordered)
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrade}");
            }
        }   
    }
}
