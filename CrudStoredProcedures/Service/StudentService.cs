using CrudStoredProcedures.Context;
using CrudStoredProcedures.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudStoredProcedures.Service
{
    public class StudentService : IStudentService
    {
        DatabaseContext _dbContext = null;

        public StudentService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Student> GetStudents(string name)
        {
            var students = _dbContext.Students.FromSqlRaw($"GetStudents {name}").ToList();
            return students;
        }

        public void SaveOrUpdate(Student student)
        {
            _dbContext.Database.ExecuteSqlRaw($"SaveOrUpdateStudent {student.StudentId}, {student.Name}, {student.Age}");

            // Test
            var students = _dbContext.Students.ToList();
        }

        public void Delete(int studentId)
        {
            _dbContext.Database.ExecuteSqlRaw($"DeleteStudent {studentId}");

            // Test
            var students = _dbContext.Students.ToList();

        }
    }
}
