namespace LearningService.ValueObjects.Exceptions.DateOfBirthExceptions;

public class DateOfBirthInFutureException(DateOnly date)
    : ValueObjectException($"Дата рождения {date:d} не может быть в будущем или сегодняшней датой.")
{
    public DateOnly Date => date;
}

public class StudentTooYoungException(int age, int minAge)
    : ValueObjectException($"Возраст студента {age} лет меньше допустимого минимума {minAge} лет.")
{
    public int Age => age;
    public int MinAge => minAge;
}

public class InvalidDateOfBirthException(DateOnly date)
    : ValueObjectException($"Дата рождения {date:d} некорректна.")
{
    public DateOnly Date => date;
}
