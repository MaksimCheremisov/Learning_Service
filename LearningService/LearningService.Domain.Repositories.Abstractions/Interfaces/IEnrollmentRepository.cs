using LearningService.Domain.Entities;
using LearningService.Domain.Repositories.Abstractions.Base;

namespace LearningService.Domain.Repositories.Abstractions.Interfaces;

public interface IEnrollmentRepository : IRepository<Enrollment, int>
{
    Task<IEnumerable<Enrollment>> GetByStudentIdAsync(int studentId, CancellationToken cancellationToken);

    Task<IEnumerable<Enrollment>> GetByCourseIdAsync(int courseId, CancellationToken cancellationToken);

    Task<Enrollment?> GetActiveByStudentAndCourseAsync(int studentId, int courseId, CancellationToken cancellationToken);

    Task<int> CountActiveByCourseAsync(int courseId, CancellationToken cancellationToken);
}
