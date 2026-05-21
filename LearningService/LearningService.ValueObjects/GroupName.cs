using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Validators;

namespace LearningService.ValueObjects;

public class GroupName : ValueObject<string>
{
    public GroupName(string value)
        : base(new GroupNameValidator(), value.Trim().ToUpperInvariant())
    {
    }

    public override string ToString() => Value;
}
