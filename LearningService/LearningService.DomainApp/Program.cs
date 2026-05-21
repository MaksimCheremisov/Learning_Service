using LearningService.Domain.Entities;
using LearningService.Domain.Enums;
using LearningService.Domain.Exceptions;
using LearningService.ValueObjects;
using LearningService.ValueObjects.Exceptions;

Console.WriteLine("  Демонстрация доменной модели Learning Service: \n");


// Создание сущности преподаватель

var teacher = new Teacher(
    new FullName("Иванов Иван Иванович"),
    new Email("ivanov@university.ru"),
    new Department("Кафедра информационных технологий"));

Console.WriteLine($"Создан преподаватель: {teacher.FullName.Value}");
Console.WriteLine($"Email: {teacher.Email.Value}");
Console.WriteLine($"Кафедра: {teacher.Department.Value}");


// Смена кафедры у преподавателя
Console.WriteLine("\nДемонстрация смены кафедры преподавателя");
Console.WriteLine($"Старая кафедра: {teacher.Department.Value}");
teacher.ChangeDepartment(new Department("Кафедра программной инженерии"));
Console.WriteLine($"Новая кафедра: {teacher.Department.Value}");


// Создание сущности курса

var course = new Course(
    new CourseTitle("Основы C# и .NET"),
    new CourseDescription("Введение в объектно-ориентированное программирование на C#"),
    teacher);

Console.WriteLine($"\nСоздан курс: {course.Title.Value}");
Console.WriteLine($"Описание: {course.Description.Value}");


// Создание сущности студента

var student = new Student(
    new FullName("Петров Пётр Петрович"),
    new Email("petrov@student.ru"),
    new DateOfBirth(new DateOnly(2001, 5, 15)),
    new GroupName("ИТ-21"));

Console.WriteLine($"\nСоздан студент: {student.FullName.Value}");
Console.WriteLine($"Группа: {student.GroupName.Value}");
Console.WriteLine($"Возраст: {student.GetAge()} лет");


// Запись студента на курс

var enrollment = new Enrollment(student, course);
Console.WriteLine($"\nСтудент записан на курс. Статус: {enrollment.Status}");


// Демонстрация функционала преподавателя(подтверждение, отчисление)

try
{
    teacher.ApproveEnrollment(enrollment);
    Console.WriteLine($"\nПреподаватель подтвердил запись. Статус: {enrollment.Status}");

    Console.WriteLine("\nПреподаватель отчисляет студента");
    teacher.DropEnrollment(enrollment);
    Console.WriteLine($"Студент отчислен. Статус: {enrollment.Status}");

    Console.WriteLine("\nПробуем отчислить повторно (должна быть ошибка)...");
    teacher.DropEnrollment(enrollment);
}
catch (DomainException ex)
{
    Console.WriteLine($"Ошибка доменной логики: {ex.Message}");
}


// Перевод студента в другую группу

Console.WriteLine("\n  Перевод студента в другую группу: ");
student.TransferToGroup(new GroupName("ИТ-22"));
Console.WriteLine($"Новая группа: {student.GroupName.Value}");


// Валидация ValueObject'ов

Console.WriteLine("\n  Проверка валидации Value Objects:");

try
{
    var badEmail = new Email("не_валидный_email");
}
catch (ValueObjectException ex)
{
    Console.WriteLine($"Ошибка Email VO: {ex.Message}");
}

try
{
    var futureDate = new DateOfBirth(new DateOnly(2020, 1, 1));
}
catch (ValueObjectException ex)
{
    Console.WriteLine($"Ошибка DateOfBirth VO: {ex.Message}");
}

try
{
    var emptyName = new FullName("   ");
}
catch (ValueObjectException ex)
{
    Console.WriteLine($"Ошибка FullName VO: {ex.Message}");
}

try
{
    var emptyGroup = new GroupName("");
}
catch (ValueObjectException ex)
{
    Console.WriteLine($"Ошибка GroupName VO: {ex.Message}");
}

