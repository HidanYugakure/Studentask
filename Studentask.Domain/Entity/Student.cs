using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentask.Domain.Entity
{
    public class Student
    {
        private static int iD = 1;
        public int ID { get; }
        public string FullName { get; set; }
        public int Point { get; set; }

        public Student(int id, string fullame, int point)
        {
            ID = iD++;
            FullName = fullame;
            Point = point;
        }

        public void StudentInfo()
        {
            Console.WriteLine(ToString);
        }
        public override string ToString()
        {
            return $"ID-si {ID}, FullInfo {FullName}, Point {Point}";
        }
    }
}
