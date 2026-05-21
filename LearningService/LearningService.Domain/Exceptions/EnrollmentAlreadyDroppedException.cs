using LearningService.Domain.Entities;

namespace LearningService.Domain.Exceptions;

public class EnrollmentAlreadyDroppedException(Enrollment enrollment)
    : DomainException(
        $"Запись {enrollment.Id} уже была отчислена.")
{
    public Enrollment Enrollment => enrollment;
}
