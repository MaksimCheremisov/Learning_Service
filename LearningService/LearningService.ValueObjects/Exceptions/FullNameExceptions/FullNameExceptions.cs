namespace LearningService.ValueObjects.Exceptions.FullNameExceptions;

public class FullNameNullOrWhiteSpaceException()
    : ValueObjectException("ФИО не может быть пустым.")
{
}

public class FullNameTooLongException(string name, int maxLength)
    : ValueObjectException($"ФИО '{name}' превышает максимальную длину {maxLength}.")
{
    public string Name => name;
    public int MaxLength => maxLength;
}
