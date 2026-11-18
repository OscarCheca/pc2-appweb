namespace pc212053u201621873.Shared.Domain.Model.Entities;

public interface IAuditableEntity
{
    /// <summary>
    ///     Gets or sets the UTC timestamp when the entity was first persisted.
    /// </summary>
    DateTimeOffset? CreatedAt { get; set; }

    /// <summary>
    ///     Gets or sets the UTC timestamp when the entity was last saved.
    /// </summary>
    DateTimeOffset? UpdatedAt { get; set; }
}