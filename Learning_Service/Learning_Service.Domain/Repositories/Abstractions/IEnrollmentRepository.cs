using Learning_Service.Domain.Entities;

namespace Learning_Service.Domain.Repositories.Abstractions;

public interface IEnrollmentRepository
{
    Task<Enrollment?> GetByIdAsync(int id);
    Task AddAsync(Enrollment enrollment);
    Task UpdateAsync(Enrollment enrollment);
    Task DeleteAsync(int id);
}

