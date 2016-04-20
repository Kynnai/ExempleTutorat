#region using
using System.Collections.Generic;
using DataLayer.Entities;
using DataLayer.EntityFramework;
using DomainLayer.Tutor;
using Tutoring.ViewObjects;
using Tutoring.Views;
#endregion

namespace Tutoring.Controllers
{
    public class TutorController
    {
        private readonly TutorStudentManager _tutorService;

        public TutorController()
        {
            _tutorService = new TutorStudentManager(new EfEntityRepository<TutorStudentDal>(new EfTutoringDbContext()));
        }

        public void ListAll()
        {
            // Demande au service la liste des tuteurs
            var tutorList = _tutorService.GetAllTutors();
            // Fait un map entre les objets du domaine et les DTO VO
            var tutorListDto = new List<TutorListVO>();
            // Crée la vue et l'affiche
            foreach (var tutor in tutorList)
            {
                tutorListDto.Add(new TutorListVO()
                {
                    Number = tutor.Number,
                    LastName = tutor.LastName
                });
            }
            // Créer la vue et l'affiche
            new TutorListViews(tutorListDto).Display();
        }
    }
}
