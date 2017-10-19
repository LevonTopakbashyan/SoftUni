namespace p04___AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AverageGrades
    {
        public static void Main()
        {
            var students = new List<Student>();
            int numberOfStudents = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfStudents; i++)
            {
                var studentsInput = Console.ReadLine().Split().ToList();
                string studentName = studentsInput[0];
                studentsInput.Remove(studentsInput[0]);
                List<double> studentGrades = studentsInput.Select(double.Parse).ToList();

                var newStudent = new Student
                {
                    Name = studentName,
                    Grade = studentGrades
                };

                students.Add(newStudent);
            }

            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].AverageGrade < 5.00)
                {
                    students.Remove(students[i]);
                }
            }

            var result = students.OrderBy(x => x.Name).ThenByDescending(x => x.AverageGrade).ToList();

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:F2}");
            }
        }
    }
}
