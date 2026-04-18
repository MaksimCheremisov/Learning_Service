namespace Learning_Service.ValueObjects.Exceptions;

public sealed class InvalidTeacherDataException : DomainException
{
    public InvalidTeacherDataException(string message) : base(message)
    {
    }
}
