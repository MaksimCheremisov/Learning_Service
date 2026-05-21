namespace LearningService.ValueObjects.Exceptions.CourseDescriptionExceptions;

public class CourseDescriptionTooLongException(string description, int maxLength)
    : ValueObjectException($"Описание курса превышает максимальную длину {maxLength}.")
{
    public string Description => description;
    public int MaxLength => maxLength;
}
