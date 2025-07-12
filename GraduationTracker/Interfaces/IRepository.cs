using System.Collections.Generic;

namespace GraduationTracker.Interfaces
{
    /// <summary>
    /// Represents a generic repository for entities.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    public interface IRepository<T> where T : IEntity
    {
        /// <summary>
        /// Gets an entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the entity.</param>
        /// <returns>The entity with the specified unique identifier.</returns>
        T GetById(int id);

        /// <summary>
        /// Gets all entities of this type.
        /// </summary>
        /// <returns>An enumerable collection of all entities.</returns>
        IEnumerable<T> GetAll();
    }
} 