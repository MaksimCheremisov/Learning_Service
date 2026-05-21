namespace LearningService.Domain.Exceptions;

public class InvalidIdException : DomainException
{
    public InvalidIdException() : base("Идентификатор сущности не может быть пустым или некорректным.")
    {
    }
}
