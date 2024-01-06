using StudentManagementSystem.Models;

namespace StudentManagementSystem.Interfaces
{
    public interface IStudent
    {
        IEnumerable<Student> GetStudents();
        Student Details(string id);
        Student Create(Student student);
        Student Edit(Student student);
        bool Delete(Student student);
        bool IsExist(string id);


    }
}
