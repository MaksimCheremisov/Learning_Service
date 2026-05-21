using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Exceptions.DepartmentExceptions;

namespace LearningService.ValueObjects.Validators;

public class DepartmentValidator : IValidator<string>
{
    public static int MAX_LENGTH => 200;

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new DepartmentNullOrWhiteSpaceException();

        if (value.Length > MAX_LENGTH)
            throw new DepartmentTooLongException(value, MAX_LENGTH);
    }
}
