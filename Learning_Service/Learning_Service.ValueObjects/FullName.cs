using Learning_Service.ValueObjects.Base;
using Learning_Service.ValueObjects.Validators;


namespace Learning_Service.ValueObjects;

public sealed class FullName : ValueObject<string>
{
    public FullName(string value)
        : base(new FullNameValidator(), Normalize(value))
    {
    }

    private static string Normalize(string value)
        => value.Trim();
}

