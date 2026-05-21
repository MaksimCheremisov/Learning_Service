using LearningService.Domain.Entities;
using LearningService.Domain.Repositories.Abstractions.Base;

namespace LearningService.Domain.Repositories.Abstractions.Interfaces;

public interface ITeacherRepository : IRepository<Teacher, int>
{
    Task<Teacher?> GetByEmailAsync(string email, CancellationToken cancellationToken);

    Task<IEnumerable<Teacher>> GetByDepartmentAsync(string department, CancellationToken cancellationToken);

    Task<bool> ExistsByEmailAsync(string email, CancellationToken cancellationToken);
}
