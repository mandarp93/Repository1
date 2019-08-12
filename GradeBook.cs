using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        private string name;

        public GradeBook()
        {
            name = "Empty";
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeBookStats ComputeStats()
        {
            GradeBookStats stats = new GradeBookStats();
            float sum = 0;
           
            foreach (float grade in grades)
            {
                stats.Highgrade = Math.Max(grade, stats.Highgrade);
                stats.Lowgrade = Math.Min(grade, stats.Lowgrade);
                sum += grade;
            }
            stats.AvgGrade = sum / grades.Count;
            return stats;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    if (name != value)
                    {
                      NameChanged(name, value);
                    }
                }
            }
        }
        private List<float> grades;
        public NameChangedDelegate NameChanged;
    }
}
