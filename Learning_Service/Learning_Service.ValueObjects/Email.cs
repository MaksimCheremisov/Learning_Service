using Learning_Service.ValueObjects.Base;
using Learning_Service.ValueObjects.Validators;


namespace Learning_Service.ValueObjects;

public sealed class Email : ValueObject<string>
{
    public Email(string value)
        : base(new EmailValidator(), Normalize(value))
    {
    }

    public string GetDomain()
        => Value.Split('@')[1];

    private static string Normalize(string value)
        => value.Trim().ToLowerInvariant();
}
