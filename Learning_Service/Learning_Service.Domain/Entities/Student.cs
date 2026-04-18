using Learning_Service.Domain.Exceptions;
using Learning_Service.ValueObjects;

namespace Learning_Service.Domain.Entities;

public class Student
{
    public int Id { get; }
    public Email Email { get; private set; }
    public FullName FullName { get; private set; }
    public DateTime DateOfBirth { get; private set; }
    public GroupName GroupName { get; private set; }
    public DateTime CreatedAt { get; }

    public Student(int id, Email email, FullName fullName, DateTime dateOfBirth, GroupName groupName)
    {
        if (id <= 0)
            throw new InvalidIdException();

        Id = id;
        Email = email ?? throw new ArgumentNullException(nameof(email));
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        GroupName = groupName ?? throw new ArgumentNullException(nameof(groupName));
        DateOfBirth = dateOfBirth;
        CreatedAt = DateTime.UtcNow;
    }

    public void UpdateProfile(FullName fullName, GroupName groupName, Email email)
    {
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
        GroupName = groupName ?? throw new ArgumentNullException(nameof(groupName));
        Email = email ?? throw new ArgumentNullException(nameof(email));
    }
}
