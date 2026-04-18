namespace Learning_Service.ValueObjects.Exceptions;

public abstract class ValueObjectException : Exception
{
    protected ValueObjectException(string message) : base(message) { }
}