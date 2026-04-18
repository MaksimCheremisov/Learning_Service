using Learning_Service.ValueObjects.Base;
using Learning_Service.ValueObjects.Exceptions;


namespace Learning_Service.ValueObjects.Validators;

public sealed class GroupNameValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidGroupNameException();
    }
}
