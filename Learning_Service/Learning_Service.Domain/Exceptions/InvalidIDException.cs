namespace Learning_Service.Domain.Exceptions;

public sealed class InvalidIdException : DomainException
{
    public InvalidIdException()
        : base("Идентификатор должен быть больше нуля.")
    {
    }
}
