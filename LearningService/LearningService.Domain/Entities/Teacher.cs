using LearningService.Domain.Entities.Base;
using LearningService.Domain.Enums;
using LearningService.Domain.Exceptions;
using LearningService.ValueObjects;

namespace LearningService.Domain.Entities;

public class Teacher : Entity<int>
{
    public FullName FullName { get; private set; }

    public Email Email { get; private set; }

    public Department Department { get; private set; }

    public DateTime CreatedAt { get; private set; }

    protected Teacher()
    {
    }

    protected Teacher(
        int id,
        FullName fullName,
        Email email,
        Department department,
        DateTime createdAt)
        : base(id)
    {
        FullName = fullName
            ?? throw new ArgumentNullException(nameof(fullName));

        Email = email
            ?? throw new ArgumentNullException(nameof(email));

        Department = department
            ?? throw new ArgumentNullException(nameof(department));

        CreatedAt = createdAt;
    }

    public Teacher(FullName fullName, Email email, Department department)
        : this(0, fullName, email, department, DateTime.UtcNow)
    {
    }

    public void ChangeName(FullName fullName)
    {
        FullName = fullName
            ?? throw new ArgumentNullException(nameof(fullName));
    }

    public void ChangeEmail(Email email)
    {
        Email = email
            ?? throw new ArgumentNullException(nameof(email));
    }

    public void ChangeDepartment(Department department)
    {
        Department = department
            ?? throw new ArgumentNullException(nameof(department));
    }

    public void ApproveEnrollment(Enrollment enrollment)
    {
        if (enrollment is null)
            throw new ArgumentNullException(nameof(enrollment));

        if (enrollment.Course.Teacher.Id != Id)
            throw new TeacherCourseOwnershipException(this, enrollment.Course);

        enrollment.SetStatus(EnrollmentStatus.Active);
    }

    public void DropEnrollment(Enrollment enrollment)
    {
        if (enrollment is null)
            throw new ArgumentNullException(nameof(enrollment));

        if (enrollment.Course.Teacher.Id != Id)
            throw new TeacherCourseOwnershipException(this, enrollment.Course);

        if (enrollment.Status == EnrollmentStatus.Dropped)
            throw new EnrollmentAlreadyDroppedException(enrollment);

        enrollment.SetStatus(EnrollmentStatus.Dropped);
    }
}
