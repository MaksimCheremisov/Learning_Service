using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Validators;

namespace LearningService.ValueObjects;

public class CourseTitle : ValueObject<string>
{
    public CourseTitle(string value)
        : base(new CourseTitleValidator(), value.Trim())
    {
    }

    public override string ToString() => Value;
}
