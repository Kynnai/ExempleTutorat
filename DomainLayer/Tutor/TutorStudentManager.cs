#region using
using System.Collections.Generic;
using System.Linq;
using DataLayer.Entities;
using DataLayer.Interface;
#endregion

namespace DomainLayer.Tutor
{
    public class TutorStudentManager // : ITutorStudentManager
    {
        private readonly IRepository<TutorStudentDal> _tutorRepository;

        public TutorStudentManager(IRepository<TutorStudentDal> repo)
        {
            _tutorRepository = repo;
        }

        public void RegisterTutor(TutorStudent newTutor)
        {
            // Validation: matricule unique
            var tutorStudentDal = new TutorStudentDal
            {
                Number = newTutor.Number,
                LastName = newTutor.LastName
            };
            //Mapping Domain object -- Dal object
            _tutorRepository.Add(tutorStudentDal);
        }

        public IQueryable<TutorStudent> GetAllTutors()
        {
            var tutors = new List<TutorStudent>();

            foreach (var tutorDal in _tutorRepository.GetAll())
            {
                tutors.Add(new TutorStudent()
                {
                       Id = tutorDal.Id,
                       Number = tutorDal.Number,
                       LastName = tutorDal.LastName
                });
            }

            return tutors.AsQueryable();
        }
    }
}
