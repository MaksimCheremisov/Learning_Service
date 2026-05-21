using LearningService.Domain.Entities;
using LearningService.Domain.Repositories.Abstractions.Base;

namespace LearningService.Domain.Repositories.Abstractions.Interfaces;

public interface IStudentRepository : IRepository<Student, int>
{
    Task<Student?> GetByEmailAsync(string email, CancellationToken cancellationToken);

    Task<IEnumerable<Student>> GetByGroupAsync(string groupName, CancellationToken cancellationToken);

    Task<bool> ExistsByEmailAsync(string email, CancellationToken cancellationToken);
}
