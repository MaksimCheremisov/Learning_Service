namespace LearningService.ValueObjects.Exceptions.DepartmentExceptions;

public class DepartmentNullOrWhiteSpaceException()
    : ValueObjectException("Название кафедры не может быть пустым.")
{
}

public class DepartmentTooLongException(string department, int maxLength)
    : ValueObjectException($"Название кафедры '{department}' превышает максимальную длину {maxLength}.")
{
    public string Department => department;
    public int MaxLength => maxLength;
}
