using GraduationTracker.Interfaces;
using GraduationTracker.Models;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Repositories
{
    /// <summary>
    /// Represents a repository for managing students.
    /// </summary>
    public class StudentRepository : IRepository<Student>
    {
        private readonly List<Student> _students;

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentRepository"/> class.
        /// </summary>
        public StudentRepository()
        {
            _students =
            [
                new Student
               {
                   Id = 1,
                   Courses =
                   [
                        new Course{Id = 1, Name = "Math", Mark=95 },
                        new Course{Id = 2, Name = "Science", Mark=95 },
                        new Course{Id = 3, Name = "Literature", Mark=95 },
                        new Course{Id = 4, Name = "Physical Education", Mark=95 }
                   ]
               },
               new Student
               {
                   Id = 2,
                   Courses =
                   [
                        new Course{Id = 1, Name = "Math", Mark=79 },
                        new Course{Id = 2, Name = "Science", Mark=79 },
                        new Course{Id = 3, Name = "Literature", Mark=79 },
                        new Course{Id = 4, Name = "Physical Education", Mark=79 }
                   ]
               },
                new Student
                {
                    Id = 3,
                    Courses =
                    [
                        new Course{Id = 1, Name = "Math", Mark=50 },
                        new Course{Id = 2, Name = "Science", Mark=50 },
                        new Course{Id = 3, Name = "Literature", Mark=50 },
                        new Course{Id = 4, Name = "Physical Education", Mark=50 }
                    ]
                },
                new Student
                {
                    Id = 4,
                    Courses =
                    [
                        new Course{Id = 1, Name = "Math", Mark=40 },
                        new Course{Id = 2, Name = "Science", Mark=40 },
                        new Course{Id = 3, Name = "Literature", Mark=40 },
                        new Course{Id = 4, Name = "Physical Education", Mark=40 }
                    ]
                }
            ];
        }

        /// <inheritdoc/>
        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        /// <inheritdoc/>
        public Student GetById(int id)
        {
            return _students.FirstOrDefault(s => s.Id == id);
        }
    }
} 