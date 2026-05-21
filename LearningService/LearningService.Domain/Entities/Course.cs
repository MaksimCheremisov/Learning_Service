using LearningService.Domain.Entities.Base;
using LearningService.Domain.Exceptions;
using LearningService.ValueObjects;

namespace LearningService.Domain.Entities;

public class Course : Entity<int>
{
    public CourseTitle Title { get; private set; }

    public CourseDescription Description { get; private set; }

    public Teacher Teacher { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public DateTime UpdatedAt { get; private set; }

    protected Course()
    {
    }

    protected Course(
        int id,
        CourseTitle title,
        CourseDescription description,
        Teacher teacher,
        DateTime createdAt)
        : base(id)
    {
        Title = title
            ?? throw new ArgumentNullException(nameof(title));

        Description = description
            ?? throw new ArgumentNullException(nameof(description));

        Teacher = teacher
            ?? throw new ArgumentNullException(nameof(teacher));

        CreatedAt = createdAt;
        UpdatedAt = createdAt;
    }

    public Course(CourseTitle title, CourseDescription description, Teacher teacher)
        : this(0, title, description, teacher, DateTime.UtcNow)
    {
    }

    public void ChangeTitle(Teacher teacher, CourseTitle title)
    {
        if (teacher is null)
            throw new ArgumentNullException(nameof(teacher));

        if (teacher.Id != Teacher.Id)
            throw new TeacherCourseOwnershipException(teacher, this);

        Title = title
            ?? throw new ArgumentNullException(nameof(title));

        UpdatedAt = DateTime.UtcNow;
    }

    public void ChangeDescription(Teacher teacher, CourseDescription description)
    {
        if (teacher is null)
            throw new ArgumentNullException(nameof(teacher));

        if (teacher.Id != Teacher.Id)
            throw new TeacherCourseOwnershipException(teacher, this);

        Description = description
            ?? throw new ArgumentNullException(nameof(description));

        UpdatedAt = DateTime.UtcNow;
    }

    public void ReassignTeacher(Teacher currentTeacher, Teacher newTeacher, int activeEnrollmentsCount)
    {
        if (currentTeacher is null)
            throw new ArgumentNullException(nameof(currentTeacher));

        if (newTeacher is null)
            throw new ArgumentNullException(nameof(newTeacher));

        if (currentTeacher.Id != Teacher.Id)
            throw new TeacherCourseOwnershipException(currentTeacher, this);

        if (activeEnrollmentsCount > 0)
            throw new CannotReassignTeacherException(this, activeEnrollmentsCount);

        Teacher = newTeacher;
        UpdatedAt = DateTime.UtcNow;
    }
}
