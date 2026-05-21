using System.Text.RegularExpressions;
using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Exceptions.EmailExceptions;

namespace LearningService.ValueObjects.Validators;

public class EmailValidator : IValidator<string>
{
    public static int MAX_LENGTH => 254;

    private const string EMAIL_PATTERN = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

    public void Validate(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new EmailNullOrWhiteSpaceException();

        if (value.Length > MAX_LENGTH)
            throw new EmailTooLongException(value, MAX_LENGTH);

        if (!Regex.IsMatch(value, EMAIL_PATTERN))
            throw new InvalidEmailFormatException(value);
    }
}
