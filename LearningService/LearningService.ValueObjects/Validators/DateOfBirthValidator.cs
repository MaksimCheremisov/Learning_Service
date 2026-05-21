using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Exceptions.DateOfBirthExceptions;

namespace LearningService.ValueObjects.Validators;

public class DateOfBirthValidator : IValidator<DateOnly>
{
    public static int MIN_AGE => 14;
    public static int MAX_AGE => 100;

    public void Validate(DateOnly value)
    {
        var today = DateOnly.FromDateTime(DateTime.UtcNow);

        if (value >= today)
            throw new DateOfBirthInFutureException(value);

        var age = today.Year - value.Year;
        if (value > today.AddYears(-age)) age--;

        if (age < MIN_AGE)
            throw new StudentTooYoungException(age, MIN_AGE);

        if (age > MAX_AGE)
            throw new InvalidDateOfBirthException(value);
    }
}
