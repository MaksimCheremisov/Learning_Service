namespace Learning_Service.ValueObjects.Exceptions;

public sealed class InvalidDepartmentException : ValueObjectException
{
    public InvalidDepartmentException() : base ("Название кафедры не может быть null")
    { }
}