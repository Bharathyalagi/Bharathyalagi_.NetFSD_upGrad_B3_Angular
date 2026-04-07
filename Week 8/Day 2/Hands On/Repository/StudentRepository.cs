using Dapper;
using WebApplication8._2.Models;
using WebApplication8._2.Data;

namespace WebApplication8._2.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly DapperContext _context;

    public StudentRepository(DapperContext context)
    {
        _context = context;
    }

    public IEnumerable<Student> GetStudentsWithCourse()
    {
        var sql = @"SELECT s.StudentId, s.StudentName, c.CourseName
                    FROM Student s
                    JOIN Course c ON s.CourseId = c.CourseId";

        using var db = _context.CreateConnection();
        return db.Query<Student>(sql);
    }

    public IEnumerable<Course> GetCoursesWithStudents()
    {
        var sql = @"SELECT c.CourseId, c.CourseName,
                    s.StudentId, s.StudentName
                    FROM Course c
                    LEFT JOIN Student s ON c.CourseId = s.CourseId";

        using var db = _context.CreateConnection();

        var dict = new Dictionary<int, Course>();

        var result = db.Query<Course, Student, Course>(
            sql,
            (course, student) =>
            {
                if (!dict.TryGetValue(course.CourseId, out var current))
                {
                    current = course;
                    current.Students = new List<Student>();
                    dict.Add(current.CourseId, current);
                }

                if (student != null)
                    current.Students.Add(student);

                return current;
            },
            splitOn: "StudentId"
        );

        return dict.Values;
    }
}