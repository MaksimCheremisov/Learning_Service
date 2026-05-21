using LearningService.Domain.Entities;

namespace LearningService.Domain.Exceptions;

public class StudentAlreadyEnrolledException(Student student, Course course)
    : DomainException(
        $"Студент {student.Id} уже записан на курс {course.Id}.")
{
    public Student Student => student;
    public Course Course => course;
}
