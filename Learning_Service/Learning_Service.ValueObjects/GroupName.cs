using Learning_Service.ValueObjects.Base;
using Learning_Service.ValueObjects.Validators;


namespace Learning_Service.ValueObjects;

public sealed class GroupName : ValueObject<string>
{
    public GroupName(string value)
        : base(new GroupNameValidator(), value.Trim())
    {
    }
}

