using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Validators;

namespace LearningService.ValueObjects;

public class CourseDescription : ValueObject<string>
{
    public CourseDescription(string value)
        : base(new CourseDescriptionValidator(), value?.Trim() ?? string.Empty)
    {
    }

    public bool IsEmpty => string.IsNullOrWhiteSpace(Value);

    public override string ToString() => Value;
}
