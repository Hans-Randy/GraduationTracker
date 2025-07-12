namespace GraduationTracker.Models
{
    /// <summary>
    /// Represents a course with a name, mark, and credits.
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Gets or sets the unique identifier for the course.
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the mark for the course.
        /// </summary>
        public int Mark { get; set; }
     }
}
