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
        IGraduationTracker tracker;
        Diploma diploma;
        Requirement[] requirements;
        Student[] students;

        [TestInitialize]
        public void TestInitialize()
        {
            var studentRepository = new StudentRepository();
            var diplomaRepository = new DiplomaRepository();
            var requirementRepository = new RequirementRepository();

            diploma = diplomaRepository.GetAll().First();
            requirements = requirementRepository.GetAll().ToArray();
            students = studentRepository.GetAll().ToArray();

            tracker = new Services.GraduationTracker(diplomaRepository, requirementRepository, studentRepository);
        }

        [TestMethod]
        public void TestHasAllCredits()
        {
            var student = students.First(s => s.Id == 1);
            var result = tracker.HasGraduated(diploma, student);
            Assert.IsTrue(result.Item1);
        }

        [TestMethod]
        public void TestIsAverage()
        {
            var student = students.First(s => s.Id == 2);
            var result = tracker.HasGraduated(diploma, student);
            Assert.IsTrue(result.Item1);
            Assert.IsTrue(result.Item2 == Standing.Average);
        }

        [TestMethod]
        public void TestIsRemedial()
        {
            var student = students.First(s => s.Id == 4);
            var result = tracker.HasGraduated(diploma, student);
            Assert.IsFalse(result.Item1);
            Assert.IsTrue(result.Item2 == Standing.Remedial);
        }

        [TestMethod]
        public void TestIsSummaCumLaude()
        {
            var student = students.First(s => s.Id == 1);
            var result = tracker.HasGraduated(diploma, student);
            Assert.IsTrue(result.Item1);
            Assert.IsTrue(result.Item2 == Standing.SummaCumLaude);
        }
    }
}
