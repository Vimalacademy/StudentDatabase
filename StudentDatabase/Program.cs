using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentDbContext())
            {

                // Create a new student
                var newStudent = new Student
                {
                    Name = "John Doe",
                    EnrollmentDate = DateTime.Now
                };

                // Add the student to the database
                context.Students.Add(newStudent);
                context.SaveChanges();

                Console.WriteLine("Student added to the database.");
            }
        }
    }
}



