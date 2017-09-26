using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransfertObjectPattern.Classes;

namespace TransfertObjectPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            StudentBO studentBusinessObject = new StudentBO();

            // Print all students
            foreach (StudentVO stud in studentBusinessObject.GetAllStudents())
            {
                Console.WriteLine("Student [No : {0}, Name : {1}]", stud.RollNo, stud.Name);
            }

            Console.WriteLine("\n");

            // Update students
            StudentVO student = studentBusinessObject.GetAllStudents()[0];
            student.Name = "Claire";
            studentBusinessObject.UpdateStudent(student);

            // Get the student
            student = studentBusinessObject.GetStudentByNo(student.RollNo);
            Console.WriteLine("Student [No : {0}, Name : {1}]", student.RollNo, student.Name);

            Console.ReadLine();
        }
    }
}
