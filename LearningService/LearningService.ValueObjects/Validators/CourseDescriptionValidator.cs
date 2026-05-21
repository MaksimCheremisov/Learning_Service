using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Exceptions.CourseDescriptionExceptions;

namespace LearningService.ValueObjects.Validators;

public class CourseDescriptionValidator : IValidator<string>
{
    public static int MAX_LENGTH => 4000;

    public void Validate(string value)
    {
        if (value is not null && value.Length > MAX_LENGTH)
            throw new CourseDescriptionTooLongException(value, MAX_LENGTH);
    }
}
