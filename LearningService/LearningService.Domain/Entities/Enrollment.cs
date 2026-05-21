using LearningService.Domain.Entities.Base;
using LearningService.Domain.Enums;
using LearningService.Domain.Exceptions;

namespace LearningService.Domain.Entities;

public class Enrollment : Entity<int>
{
    public Student Student { get; private set; }

    public Course Course { get; private set; }

    public EnrollmentStatus Status { get; private set; }

    public DateTime EnrolledAt { get; private set; }

    public DateTime? LeftAt { get; private set; }

    protected Enrollment()
    {
    }

    protected Enrollment(
        int id,
        Student student,
        Course course,
        EnrollmentStatus status,
        DateTime enrolledAt)
        : base(id)
    {
        Student = student
            ?? throw new ArgumentNullException(nameof(student));

        Course = course
            ?? throw new ArgumentNullException(nameof(course));

        Status = status;
        EnrolledAt = enrolledAt;
    }

    public Enrollment(Student student, Course course)
        : this(0, student, course, EnrollmentStatus.Active, DateTime.UtcNow)
    {
    }

    internal void SetStatus(EnrollmentStatus status)
    {
        if (Status == EnrollmentStatus.Dropped && status == EnrollmentStatus.Dropped)
            throw new EnrollmentAlreadyDroppedException(this);

        Status = status;

        if (status == EnrollmentStatus.Dropped || status == EnrollmentStatus.Completed)
            LeftAt = DateTime.UtcNow;
    }

    public bool IsActive => Status == EnrollmentStatus.Active;
}
