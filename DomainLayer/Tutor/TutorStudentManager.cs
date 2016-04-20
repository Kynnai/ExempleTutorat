#region using
using System.Collections.Generic;
using System.Linq;
using DataLayer.Entities;
using DataLayer.Interface;
using DomainLayer.Mappers;

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

        /// <summary>
        /// Sans mappeur
        /// </summary>
        /// <param name="newTutor"></param>
        /*public void RegisterTutor(TutorStudent newTutor)
        {
            // Validation: matricule unique
            var tutorStudentDal = new TutorStudentDal
            {
                Number = newTutor.Number,
                LastName = newTutor.LastName
            };
            //Mapping Domain object -- Dal object
            _tutorRepository.Add(tutorStudentDal);
        }*/

        /// <summary>
        /// Avec mappeur
        /// </summary>
        public void RegisterTutor(TutorStudent newTutor)
        {
            // Validation: matricule unique
            var dal = MapperTutorStudent.Map(newTutor);
            //Mapping Domain object -- Dal object
            _tutorRepository.Add(dal);
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
