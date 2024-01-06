using StudentManagementSystem.Data;

namespace StudentManagementSystem.Interfaces
{
    public interface IDBInitializer
    {
        void Initialize(SQliteDbContext context);
    }
}
