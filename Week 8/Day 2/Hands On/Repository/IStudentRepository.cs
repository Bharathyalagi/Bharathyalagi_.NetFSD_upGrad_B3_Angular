using WebApplication8._2.Models;

namespace WebApplication8._2.Repositories;

public interface IStudentRepository
{
    IEnumerable<Student> GetStudentsWithCourse();
    IEnumerable<Course> GetCoursesWithStudents();
}