using Learning_Service.ValueObjects.Exceptions;
namespace Learning_Service.ValueObjects.Exceptions;

public sealed class InvalidFullNameException : ValueObjectException
{
    public InvalidFullNameException()
        : base("Некорректное полное имя.")
    {
    }
}