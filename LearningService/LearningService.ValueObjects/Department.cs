using LearningService.ValueObjects.Base;
using LearningService.ValueObjects.Validators;

namespace LearningService.ValueObjects;

public class Department : ValueObject<string>
{
    public Department(string value)
        : base(new DepartmentValidator(), value.Trim())
    {
    }

    public override string ToString() => Value;
}
