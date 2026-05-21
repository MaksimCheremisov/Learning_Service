using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Exceptions.CourseTitleExceptions;

namespace LearningService.ValueObjects.Validators;

public class CourseTitleValidator : IValidator<string>
{
    public static int MAX_LENGTH => 300;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new CourseTitleNullOrWhiteSpaceException();

        if (value.Length > MAX_LENGTH)
            throw new CourseTitleTooLongException(value, MAX_LENGTH);
    }
}
