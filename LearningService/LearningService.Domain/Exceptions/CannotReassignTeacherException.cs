using LearningService.Domain.Entities;

namespace LearningService.Domain.Exceptions;

public class CannotReassignTeacherException(Course course, int activeCount)
    : DomainException(
        $"Нельзя переназначить преподавателя курса {course.Id}: " +
        $"есть {activeCount} активных записей студентов.")
{
    public Course Course => course;
    public int ActiveCount => activeCount;
}
