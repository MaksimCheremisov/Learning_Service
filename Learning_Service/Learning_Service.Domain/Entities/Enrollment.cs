using Learning_Service.Domain.Enums;
using Learning_Service.Domain.Exceptions;

namespace Learning_Service.Domain.Entities;

public class Enrollment
{
    public int Id { get; }
    public int StudentId { get; }
    public int CourseId { get; }
    public DateTime EnrolledAt { get; }
    public DateTime? LeftAt { get; private set; }
    public EnrollmentStatus Status { get; private set; }

    public Enrollment(int id, int studentId, int courseId)
    {
        if (id <= 0)
            throw new InvalidIdException();

        if (studentId <= 0)
            throw new InvalidIdException();

        if (courseId <= 0)
            throw new InvalidIdException();

        Id = id;
        StudentId = studentId;
        CourseId = courseId;
        EnrolledAt = DateTime.UtcNow;
        Status = EnrollmentStatus.Active;
    }

    public void LeaveCourse()
    {
        if (Status == EnrollmentStatus.Left)
            throw new StudentNotEnrolledException();

        LeftAt = DateTime.UtcNow;
        Status = EnrollmentStatus.Left;
    }

    public bool IsActive()
    {
        return Status == EnrollmentStatus.Active;
    }
}
