using Learning_Service.Domain.Entities;

namespace Learning_Service.Domain.Repositories.Abstractions;

public interface IStudentRepository
{
    Task<Student?> GetByIdAsync(int id);
    Task AddAsync(Student student);
    Task UpdateAsync(Student student);
    Task DeleteAsync(int id);
}

