using LearningService.ValueObjects.Exceptions;

namespace LearningService.ValueObjects.Base;

public abstract class ValueObject<T> : IEquatable<ValueObject<T>>
{
    public T Value { get; }

    protected ValueObject(IValidator<T> validator, T value)
    {
        if (validator is null)
            throw new ValidatorNullException(nameof(validator));

        validator.Validate(value);
        Value = value;
    }

    public override bool Equals(object? obj)
        => Equals(obj as ValueObject<T>);

    public bool Equals(ValueObject<T>? other)
    {
        if (other is null) return false;
        if (GetType() != other.GetType()) return false;

        return EqualityComparer<T>.Default.Equals(Value, other.Value);
    }

    public override int GetHashCode()
        => HashCode.Combine(GetType(), Value);

    public override string ToString()
    {
        return Value?.ToString() ?? string.Empty;
    }
}
