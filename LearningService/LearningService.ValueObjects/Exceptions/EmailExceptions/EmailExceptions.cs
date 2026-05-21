namespace LearningService.ValueObjects.Exceptions.EmailExceptions;

public class EmailNullOrWhiteSpaceException()
    : ValueObjectException("Email не может быть пустым.")
{
}

public class EmailTooLongException(string email, int maxLength)
    : ValueObjectException($"Email '{email}' превышает максимальную длину {maxLength}.")
{
    public string Email => email;
    public int MaxLength => maxLength;
}

public class InvalidEmailFormatException(string email)
    : ValueObjectException($"Email '{email}' имеет некорректный формат.")
{
    public string Email => email;
}
