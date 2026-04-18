namespace Learning_Service.Domain.Exceptions;

public sealed class StudentAlreadyEnrolledException : DomainException
{
    public StudentAlreadyEnrolledException()
        : base("Студент уже записан на этот курс.")
    {
    }
}
