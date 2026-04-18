using Learning_Service.Domain.Entities;


namespace Learning_Service.Domain.Repositories.Abstractions;

public interface ITeacherRepository
{
    Task<Teacher?> GetByIdAsync(int id);
    Task AddAsync(Teacher teacher);
    Task UpdateAsync(Teacher teacher);
    Task DeleteAsync(int id);
}
