using Learning_Service.ValueObjects.Base;
using Learning_Service.ValueObjects.Validators;


namespace Learning_Service.ValueObjects;

public sealed class Department : ValueObject<string>
{
    public Department(string value)
        : base(new DepartmentValidator(), value.Trim())
    {
    }
}
