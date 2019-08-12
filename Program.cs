using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.NameChanged = new NameChangedDelegate(IfNameChanges);
            book.Name = "My name is Mandar";
            book.Name = "Book is very nice";
            book.Name = null;
            book.AddGrade(92);
            book.AddGrade(88.9f);
            book.AddGrade(75);
            
            // GradeBook book2 = book;
            GradeBookStats stats = book.ComputeStats();
            Console.WriteLine(stats.Highgrade);
            Console.WriteLine(stats.Lowgrade);
            Console.WriteLine(stats.AvgGrade);
           // Console.WriteLine(book.Name);
        }

        public static void IfNameChanges(string existName, string newName)
        {
            Console.WriteLine($" GradeBook name changes from {existName} to {newName}");
        }
    }
}
