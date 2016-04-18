#region using
using System.Collections.Generic;
using System.Linq;
using DataLayer.Entities;
using DataLayer.Interface;
using DomainLayer.Tutor;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
#endregion

namespace Domaine.UnitTest
{
    /// <summary>
    /// Description résumée pour TutorManagerTest
    /// </summary>
    [TestClass]
    public class TutorManagerTest
    {
        private TutorStudentManager _tutoService;
        private IRepository<TutorStudentDal> _tutorRepository;

        [TestInitialize]
        public void TutorManagerTestInit()
        {
            _tutorRepository = Substitute.For<IRepository<TutorStudentDal>>();
            _tutoService = new TutorStudentManager(_tutorRepository);
        }

        [TestMethod]
        public void GetAllTutors_ShouldReturnAllTutors()
        {
            //Arrange
            const int expectTutorCount = 3;

            var tutorDal1 = new TutorStudentDal() { Id = 1, Number = 112345, LastName = "Zozo1" };
            var tutorDal2 = new TutorStudentDal() { Id = 2, Number = 212345, LastName = "Zozo2" };
            var tutorDal3 = new TutorStudentDal() { Id = 3, Number = 312345, LastName = "Zozo3" };

            var tutors = new List<TutorStudentDal> {tutorDal1, tutorDal2, tutorDal3};

            _tutorRepository.GetAll().Returns(tutors.AsQueryable());

            //Act
            var tutorStudentList = _tutoService.GetAllTutors();

            //Assert
            Assert.AreEqual(expectTutorCount, tutorStudentList.Count());

            //Avec Fluent Assertions
            tutorStudentList.Count().ShouldBeEquivalentTo(expectTutorCount);
        }
    }
}
