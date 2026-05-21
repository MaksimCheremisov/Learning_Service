using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Validators;

namespace LearningService.ValueObjects;

public class DateOfBirth : ValueObject<DateOnly>
{
    public DateOfBirth(DateOnly value)
        : base(new DateOfBirthValidator(), value)
    {
    }

    public int GetAge()
    {
        var today = DateOnly.FromDateTime(DateTime.UtcNow);
        var age = today.Year - Value.Year;
        if (Value > today.AddYears(-age)) age--;
        return age;
    }

    public override string ToString() => Value.ToString("d");
}
