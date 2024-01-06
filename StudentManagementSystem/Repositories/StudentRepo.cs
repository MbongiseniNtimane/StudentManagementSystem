using StudentManagementSystem.Data;
using StudentManagementSystem.Interfaces;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repositories
{
    public class StudentRepo : IStudent
    {
        private readonly SQliteDbContext _context;
        
        public StudentRepo(SQliteDbContext context)
        {
            _context = context;
        }
        //Repository Pattern
        public Student Create(Student student)
        {
            _context.Add(student);
            _context.SaveChanges();
            return student;
        }

        public bool Delete(Student student)
        {
            _context.Remove(student);
            _context.SaveChanges();

            return IsExist(student.StudentNumber);
        }

        public Student Details(string id)
        {
            var student = _context.Students?.FirstOrDefault(x => x.StudentNumber == id);
            return student;
        }

        public Student Edit(Student student)
        {
            _context.Update(student);
            _context.SaveChanges();
            return student;
        }

        public IEnumerable<Student> GetStudents()
        {
            //pull list of students from the Students.db(In Database folder)
            var student = _context.Students.ToList();
            return student;
        }


        public bool IsExist(string id)
        {

            bool isExist = false;
            Student existStudent = Details(id);
            if (existStudent == null)
            {
                isExist = true;
            }
            return isExist;
        }
    }
}
