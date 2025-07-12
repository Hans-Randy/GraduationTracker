using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using GraduationTracker.Models;
using GraduationTracker.Services;
using GraduationTracker.Repositories;
using GraduationTracker.Interfaces;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        IGraduationTracker _tracker;
        Diploma _diploma;
        IStudentRepository _studentRepository;

        [TestInitialize]
        public void TestInitialize()
        {
            _studentRepository = new StudentRepository();
            var diplomaRepository = new DiplomaRepository();
            var requirementRepository = new RequirementRepository();

            _diploma = diplomaRepository.GetAll().First();
            _tracker = new Services.GraduationTracker(diplomaRepository, requirementRepository, _studentRepository);
        }

        [DataTestMethod]
        [DataRow(1, true, Standing.SummaCumLaude)]
        [DataRow(2, true, Standing.Average)]
        [DataRow(3, true, Standing.Average)]
        [DataRow(4, false, Standing.Remedial)]
        public void TestStudentGraduationScenarios(int studentId, bool expectedGraduation, Standing expectedStanding)
        {
            var student = _studentRepository.GetById(studentId);
            var result = _tracker.HasGraduated(_diploma, student);

            Assert.AreEqual(expectedGraduation, result.Item1);
            Assert.AreEqual(expectedStanding, result.Item2);
        }
    }
}
