using Learning_Service.Domain.Exceptions;

namespace Learning_Service.Domain.Entities;

public class Course
{
    public int Id { get; }
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int TeacherId { get; }
    public DateTime CreatedAt { get; }
    public DateTime UpdatedAt { get; private set; }

    public Course(int id, string title, string description, int teacherId)
    {
        if (id <= 0)
            throw new InvalidIdException();

        if (teacherId <= 0)
            throw new InvalidIdException();

        if (string.IsNullOrWhiteSpace(title))
            throw new InvalidTitleException();

        Id = id;
        Title = title.Trim();
        Description = description?.Trim() ?? string.Empty;
        TeacherId = teacherId;
        CreatedAt = DateTime.UtcNow;
        UpdatedAt = DateTime.UtcNow;
    }

    public void ChangeTitle(string title)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new InvalidTitleException();

        Title = title.Trim();
        UpdatedAt = DateTime.UtcNow;
    }

    public void ChangeDescription(string description)
    {
        Description = description?.Trim() ?? string.Empty;
        UpdatedAt = DateTime.UtcNow;
    }
}
