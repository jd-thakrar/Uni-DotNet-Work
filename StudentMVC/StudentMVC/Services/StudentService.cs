using StudentMVC.Models;

namespace StudentMVC.Services
{
    public class StudentService : IStudentService
    {
        public Student GetStudent()
        {
            return new Student
            {
                Id = 1,
                Name = "Jeet",
                Course = "Computer Engineering"
            };
        }
    }
}
