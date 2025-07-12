using GraduationTracker.Interfaces;

namespace GraduationTracker.Models
{
    /// <summary>
    /// Represents a diploma with a set of requirements.
    /// </summary>
    public class Diploma : IEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the diploma.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the number of credits required for the diploma.
        /// </summary>
        public int Credits { get; set; }
        
        /// <summary>
        /// Gets or sets the collection of requirement identifiers for the diploma.
        /// </summary>
        public int[] Requirements { get; set; }
    }
}
