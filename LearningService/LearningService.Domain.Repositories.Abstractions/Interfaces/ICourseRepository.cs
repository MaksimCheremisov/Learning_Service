using LearningService.Domain.Entities;
using LearningService.Domain.Repositories.Abstractions.Base;

namespace LearningService.Domain.Repositories.Abstractions.Interfaces;

public interface ICourseRepository : IRepository<Course, int>
{
    Task<IEnumerable<Course>> GetByTeacherIdAsync(int teacherId, CancellationToken cancellationToken);

    Task<IEnumerable<Course>> SearchByTitleAsync(string query, CancellationToken cancellationToken);
}
