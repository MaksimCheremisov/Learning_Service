using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Validators;

namespace LearningService.ValueObjects;

public class FullName : ValueObject<string>
{
    public FullName(string value)
        : base(new FullNameValidator(), value.Trim())
    {
    }

    public override string ToString() => Value;
}
