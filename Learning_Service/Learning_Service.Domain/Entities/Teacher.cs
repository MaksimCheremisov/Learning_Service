using Learning_Service.ValueObjects;
using Learning_Service.ValueObjects.Exceptions;

namespace Learning_Service.Domain.Entities;

public sealed class Teacher
{
    public int Id { get; private set; }
    public Email Email { get; private set; }
    public FullName FullName { get; private set; }
    public string? Department { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }

    public Teacher(int id, Email email, FullName fullName, string? department = null)
    {
        Id = id;
        Email = email ?? throw new ArgumentNullException(nameof(email));
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        Department = NormalizeDepartment(department);
        CreatedAt = DateTime.UtcNow;
    }

    public void UpdateProfile(FullName fullName, string? department)
    {
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        Department = NormalizeDepartment(department);
        UpdatedAt = DateTime.UtcNow;
    }

    private static string? NormalizeDepartment(string? department)
    {
        if (department is null)
            return null;

        string normalized = department.Trim();
        if (normalized.Length > 100)
            throw new InvalidTeacherDataException("Название кафедры не может превышать 100 символов");

        return normalized.Length == 0 ? null : normalized;
    }
}
