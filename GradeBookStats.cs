using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBookStats
    {
        public float Highgrade;
        public float Lowgrade;
        public float AvgGrade;

        public GradeBookStats()
        {
            Highgrade = 0;
            Lowgrade = float.MaxValue;
        }
    }
}
