using Learning_Service.Domain.Entities;

namespace Learning_Service.Domain.Repositories.Abstractions;

public interface ICourseRepository
{
    Task<Course?> GetByIdAsync(int id);
    Task AddAsync(Course course);
    Task UpdateAsync(Course course);
    Task DeleteAsync(int id);
}
