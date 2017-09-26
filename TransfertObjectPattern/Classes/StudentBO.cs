using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransfertObjectPattern.Classes
{
    public class StudentBO
    {
        // List is workong as a database
        private List<StudentVO> students;

        public StudentBO()
        {
            students = new List<StudentVO>();
            StudentVO student1 = new StudentVO("Benjamin", 1);
            StudentVO student2 = new StudentVO("Alice", 2);

            students.Add(student1);
            students.Add(student2);
        }

        public void DeleteStudent(StudentVO student)
        {
            students.Remove(student);
        }

        // Retrive list of students from the database
        public List<StudentVO> GetAllStudents()
        {
            return students;
        }

        public StudentVO GetStudentByNo(int rollNo)
        {
            return students.Find(student => student.RollNo == rollNo);
        }

        public void UpdateStudent(StudentVO student)
        {
            students.Find(stud => stud.RollNo == student.RollNo).Name = student.Name;
            Console.WriteLine("Student No {0} updated in the database", student.RollNo);
        }
    }
}
