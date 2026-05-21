using LearningService.Domain.Entities;

namespace LearningService.Domain.Exceptions;

public class StudentNotEnrolledException(Student student, Course course)
    : DomainException(
        $"Студент {student.Id} не записан на курс {course.Id}.")
{
    public Student Student => student;
    public Course Course => course;
}
