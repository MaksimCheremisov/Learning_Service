using LearningService.Domain.Entities.Base;
using LearningService.Domain.Exceptions;
using LearningService.ValueObjects;

namespace LearningService.Domain.Entities;

public class Student : Entity<int>
{
    public FullName FullName { get; private set; }

    public Email Email { get; private set; }

    public DateOfBirth DateOfBirth { get; private set; }

    public GroupName GroupName { get; private set; }

    public DateTime CreatedAt { get; private set; }

    protected Student()
    {
    }

    protected Student(
        int id,
        FullName fullName,
        Email email,
        DateOfBirth dateOfBirth,
        GroupName groupName,
        DateTime createdAt)
        : base(id)
    {
        FullName = fullName
            ?? throw new ArgumentNullException(nameof(fullName));

        Email = email
            ?? throw new ArgumentNullException(nameof(email));

        DateOfBirth = dateOfBirth
            ?? throw new ArgumentNullException(nameof(dateOfBirth));

        GroupName = groupName
            ?? throw new ArgumentNullException(nameof(groupName));

        CreatedAt = createdAt;
    }

    public Student(FullName fullName, Email email, DateOfBirth dateOfBirth, GroupName groupName)
        : this(0, fullName, email, dateOfBirth, groupName, DateTime.UtcNow)
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

    public void TransferToGroup(GroupName groupName)
    {
        GroupName = groupName
            ?? throw new ArgumentNullException(nameof(groupName));
    }

    public int GetAge() => DateOfBirth.GetAge();
}
