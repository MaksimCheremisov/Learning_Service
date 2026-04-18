using Learning_Service.ValueObjects.Base;
using Learning_Service.ValueObjects.Exceptions;


namespace Learning_Service.ValueObjects.Validators;

public sealed class EmailValidator : IValidator<string>
{
    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new InvalidEmailException();

        if (!value.Contains('@'))
            throw new InvalidEmailException();

        if (value.Length > 254)
            throw new InvalidEmailException();
    }
}

