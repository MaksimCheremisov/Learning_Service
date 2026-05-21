namespace LearningService.ValueObjects.Exceptions.CourseTitleExceptions;

public class CourseTitleNullOrWhiteSpaceException()
    : ValueObjectException("Название курса не может быть пустым.")
{
}

public class CourseTitleTooLongException(string title, int maxLength)
    : ValueObjectException($"Название курса '{title}' превышает максимальную длину {maxLength}.")
{
    public string Title => title;
    public int MaxLength => maxLength;
}
