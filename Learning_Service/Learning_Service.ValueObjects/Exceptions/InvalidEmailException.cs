using Learning_Service.ValueObjects.Exceptions;

namespace Learning_Service.ValueObjects.Exceptions;

public sealed class InvalidEmailException : ValueObjectException
{
    public InvalidEmailException()
        : base("Некорректный email.")
    {
    }
}
