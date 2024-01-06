using StudentManagementSystem.Data;
using StudentManagementSystem.Interfaces;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Repositories
{
    public class DBInitializerRepo:IDBInitializer
    {
        public void Initialize(SQliteDbContext context)
        {
            context.Database.EnsureCreated();

            if (context.Students.Any())
            {
                return;
            }
            //Populating Students.db database
            var students = new Student[]
            {
                new Student{StudentNumber="224002265",FirstName="Thabiso",LastName="Khumalo",Course="Information Technology",EnrollmentDate=DateTime.Parse("2024-02-20")},
                new Student{StudentNumber="220014532",FirstName="Gift",LastName="Jonathan",Course="Computer Science",EnrollmentDate=DateTime.Parse("2020-02-22")},
                new Student{StudentNumber="221306275",FirstName="Amanda",LastName="Tlali",Course="Business Management",EnrollmentDate=DateTime.Parse("2021-02-19")},
            };
            foreach(Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }
    }
}
