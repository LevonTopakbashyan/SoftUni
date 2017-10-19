using System.Collections.Generic;
using System.Linq;

namespace p04___AverageGrades
{
    public class Student
    {
        public string Name { get; set; }

        public List<double> Grade { get; set; }

        public double AverageGrade => Grade.Average();
    }
}
