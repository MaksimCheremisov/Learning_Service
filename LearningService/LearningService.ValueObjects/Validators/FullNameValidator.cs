using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Exceptions.FullNameExceptions;

namespace LearningService.ValueObjects.Validators;

public class FullNameValidator : IValidator<string>
{
    public static int MAX_LENGTH => 200;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new FullNameNullOrWhiteSpaceException();

        if (value.Length > MAX_LENGTH)
            throw new FullNameTooLongException(value, MAX_LENGTH);
    }
}
