using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Exceptions.GroupNameExceptions;

namespace LearningService.ValueObjects.Validators;

public class GroupNameValidator : IValidator<string>
{
    public static int MAX_LENGTH => 50;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new GroupNameNullOrWhiteSpaceException();

        if (value.Length > MAX_LENGTH)
            throw new GroupNameTooLongException(value, MAX_LENGTH);
    }
}
