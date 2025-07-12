using GraduationTracker.Interfaces;

namespace GraduationTracker.Models
{
    /// <summary>
    /// Represents a student with a collection of courses.
    /// </summary>
    public class Student : IEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier for the student.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the collection of courses for the student.
        /// </summary>
        public Course[] Courses { get; set; }
    }
}
