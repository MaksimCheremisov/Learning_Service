namespace Learning_Service.Domain.Exceptions;

public sealed class StudentNotEnrolledException : DomainException
{
    public StudentNotEnrolledException()
        : base("Студент не записан на этот курс или уже выбыл.")
    {
    }
}
