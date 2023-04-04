using CrudStoredProcedures.Models;

namespace CrudStoredProcedures.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents(string name);
        void SaveOrUpdate(Student student);
        void Delete(int studentId);
    }
}
