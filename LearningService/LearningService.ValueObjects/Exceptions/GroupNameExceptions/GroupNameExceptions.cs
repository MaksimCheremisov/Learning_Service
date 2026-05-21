namespace LearningService.ValueObjects.Exceptions.GroupNameExceptions;

public class GroupNameNullOrWhiteSpaceException()
    : ValueObjectException("Название группы не может быть пустым.")
{
}

public class GroupNameTooLongException(string groupName, int maxLength)
    : ValueObjectException($"Название группы '{groupName}' превышает максимальную длину {maxLength}.")
{
    public string GroupName => groupName;
    public int MaxLength => maxLength;
}
