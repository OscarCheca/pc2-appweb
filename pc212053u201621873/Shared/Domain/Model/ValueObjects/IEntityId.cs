namespace pc212053u201621873.Shared.Domain.Model.ValueObjects;

public interface IEntityId<T> where T : struct
{
    T Value { get; }
}