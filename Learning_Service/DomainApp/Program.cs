using Learning_Service.Domain.Entities;
using Learning_Service.ValueObjects;

Console.WriteLine("=== Learning Service Demo ===\n");

var teacher = new Teacher(
    1,
    new Email("teacher@mail.com"),
    new FullName("Иван Иванов"),
    "Информатика");


Console.WriteLine($"Создан преподаватель: {teacher.FullName} (ID: {teacher.Id})");

var student = new Student(
    1,
    new Email("student@mail.com"),
    new FullName("Петр Петров"),
    new DateTime(2005, 5, 10),
    new GroupName("ИС-21"));

Console.WriteLine($"Создан студент: {student.FullName}");

var course = new Course(
    1,
    "Основы C#",
    "Базовый курс по C#",
    teacher.Id); 

Console.WriteLine($"Создан курс: {course.Title}");

var enrollment = new Enrollment(
    1,
    student.Id,
    course.Id);

Console.WriteLine($"Студент записан на курс. Статус: {enrollment.Status}");

Console.WriteLine("\nСтудент выходит с курса...");
enrollment.LeaveCourse();
Console.WriteLine($"Статус записи: {enrollment.Status}");

Console.WriteLine("\nПробуем выйти с курса ещё раз...");

try
{
    enrollment.LeaveCourse();
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}

Console.WriteLine("\n=== Конец демонстрации ===");