using Learning_Service.ValueObjects.Base;
using Learning_Service.ValueObjects.Exceptions;

namespace Learning_Service.ValueObjects.Validators;

public sealed class FullNameValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidFullNameException();

        if (value.Trim().Length < 3)
            throw new InvalidFullNameException();
    }
}
