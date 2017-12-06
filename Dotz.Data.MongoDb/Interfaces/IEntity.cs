namespace Dotz.Data.MongoDb.Entities
{
    public interface IEntity<TPrimaryKey>
    {
        //
        // Summary:
        //     Unique identifier for this entity.
        TPrimaryKey Id { get; set; }

        //
        // Summary:
        //     Checks if this entity is transient (not persisted to database and it has not
        //     an Itf.Domain.Entities.IEntity`1.Id).
        //
        // Returns:
        //     True, if this entity is transient
        bool IsTransient();
    }
}