using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Validators;

namespace LearningService.ValueObjects;

public class Email : ValueObject<string>
{
    public Email(string value)
        : base(new EmailValidator(), Normalize(value))
    {
    }

    private static string Normalize(string value)
    {
        return value.Trim().ToLowerInvariant();
    }

    public string GetDomain() => Value.Split('@')[1];

    public override string ToString() => Value;
}
