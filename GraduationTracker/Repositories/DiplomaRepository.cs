using GraduationTracker.Interfaces;
using GraduationTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Repositories
{
    /// <summary>
    /// Represents a repository for managing diplomas.
    /// </summary>
    public class DiplomaRepository : IDiplomaRepository
    {
        private readonly List<Diploma> _diplomas;

        /// <summary>
        /// Initializes a new instance of the <see cref="DiplomaRepository"/> class.
        /// </summary>
        public DiplomaRepository()
        {
            _diplomas =
            [
                new Diploma
                {
                    Id = 1,
                    Credits = 4,
                    Requirements = [100,102,103,104]
                }
            ];
        }

        /// <inheritdoc/>
        public IEnumerable<Diploma> GetAll()
        {
            return _diplomas;
        }

        /// <inheritdoc/>
        public Diploma GetById(int id)
        {
            return _diplomas.FirstOrDefault(d => d.Id == id);
        }
    }
} 