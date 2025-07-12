using GraduationTracker.Interfaces;
using GraduationTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Repositories
{
    /// <summary>
    /// Represents a repository for managing requirements.
    /// </summary>
    public class RequirementRepository : IRepository<Requirement>
    {
        private readonly List<Requirement> _requirements;

        /// <summary>
        /// Initializes a new instance of the <see cref="RequirementRepository"/> class.
        /// </summary>
        public RequirementRepository()
        {
            _requirements =
            [
                new Requirement{Id = 100, Name = "Math", MinimumMark=50, Courses = [1], Credits=1 },
                new Requirement{Id = 102, Name = "Science", MinimumMark=50, Courses = [2], Credits=1 },
                new Requirement{Id = 103, Name = "Literature", MinimumMark=50, Courses = [3], Credits=1},
                new Requirement{Id = 104, Name = "Physical Education", MinimumMark=50, Courses = [4], Credits=1 }
            ];
        }

        /// <inheritdoc/>
        public IEnumerable<Requirement> GetAll()
        {
            return _requirements;
        }

        /// <inheritdoc/>
        public Requirement GetById(int id)
        {
            return _requirements.FirstOrDefault(r => r.Id == id);
        }
    }
} 