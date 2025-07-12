using GraduationTracker.Models;
using System;

namespace GraduationTracker.Interfaces
{
    /// <summary>
    /// Defines the contract for the graduation tracking service.
    /// </summary>
    public interface IGraduationTracker
    {
        /// <summary>
        /// Checks if a student has graduated based on the diploma requirements and their courses.
        /// </summary>
        /// <param name="diploma">The diploma to check against.</param>
        /// <param name="student">The student to check.</param>
        /// <returns>A tuple containing a boolean indicating if the student has graduated and their standing.</returns>
        Tuple<bool, Standing> HasGraduated(Diploma diploma, Student student);
    }
} 