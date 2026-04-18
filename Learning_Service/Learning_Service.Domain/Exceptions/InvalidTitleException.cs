namespace Learning_Service.Domain.Exceptions;

public sealed class InvalidTitleException : DomainException
{
    public InvalidTitleException()
        : base("Название курса не может быть пустым.")
    {
    }
}
