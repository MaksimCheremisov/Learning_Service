namespace Learning_Service.ValueObjects.Exceptions;

public sealed class InvalidGroupNameException : ValueObjectException
{
    public InvalidGroupNameException() : base("Название группы не может быть null")
    { }
}