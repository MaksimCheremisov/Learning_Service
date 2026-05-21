using LearningService.Domain.Entities;

namespace LearningService.Domain.Exceptions;

public class TeacherCourseOwnershipException(Teacher teacher, Course course)
    : DomainException(
        $"Преподаватель {teacher.Id} не может редактировать курс {course.Id}, " +
        $"так как не является его автором.")
{
    public Teacher Teacher => teacher;
    public Course Course => course;
}
