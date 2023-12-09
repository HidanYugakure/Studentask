
using System.Text.RegularExpressions;

namespace Studentask.Domain.Entity
{
    public class Group
    {
        public int Id { get; set; }
        private string _groupNo;
        public string GroupNO
        {
            get { return _groupNo; }
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                    return;
                }
                Console.WriteLine("Xeta oldu yeniden yoxla");
            }
        }
        public Student[] Students = new Student[0];

        private int _studentLimit;
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value > 5 && value < 15)
                {
                    _studentLimit = value;
                    return;
                }
                Console.WriteLine("sinif doldu");
            }
        }

        public Group(int studentLimit, string groupNo)
        {
            StudentLimit = studentLimit;
            GroupNO = groupNo;
        }
        public bool CheckGroupNo(string groupNo)
        {
            return new Regex("@[A-Z] {2} [0-9] {3}").IsMatch(groupNo);
        }

        public void AddStudent(Student student)
        {
            if (Students.Length
                >= StudentLimit) return;
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }

        public void GetStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.ID == id)
                {
                    Console.WriteLine(student);
                }
                Console.WriteLine("Tapilmadi");
            }
        }

        public Student[] GetAllStudent()
        {
            return Students;
        }
    }
}

