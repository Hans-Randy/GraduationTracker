using GraduationTracker.Interfaces;

namespace GraduationTracker.Models
{
    /// <summary>
    /// Represents a requirement for a diploma.
    /// </summary>
    public class Requirement : IEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the requirement.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the requirement.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the minimum mark required for the requirement.
        /// </summary>
        public int MinimumMark { get; set; }

        /// <summary>
        /// Gets or sets the number of credits for the requirement.
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// Gets or sets the collection of course identifiers for the requirement.
        /// </summary>
        public int[] Courses { get; set; }
    }
}
