using System;
using System.Linq;
using DataLayer.Entities;
using DataLayer.EntityFramework;

namespace ExempleTutorat
{
    public class Program
    {
        private static void Main(/*string[] args*/)
        {
            Console.WriteLine("Hello World");

            var dbContext = new EfTutoringDbContext();
            var tutorRepo = new EfEntityRepository<TutorStudentDal>(dbContext);

            tutorRepo.DeleteAll();

            var tutor1 = new TutorStudentDal()
            {
                Number = 1234,
                LastName = "Bilodeau"
            };

            tutorRepo.Add(tutor1);

            var tutor2 = new TutorStudentDal()
            {
                Number = 12345,
                LastName = "Bob"
            };

            tutorRepo.Add(tutor2);

            var tutorList = tutorRepo.GetAll();
            Console.WriteLine("Liste des tuteurs");
            foreach (var tutor in tutorList)
            {
                Console.WriteLine(tutor.Number + " - " + tutor.LastName);
            }
            Console.ReadKey();

            var tutorsList = tutorRepo.GetAll();
            var tutorsGagnon = tutorsList.Where(t => t.LastName == "Gagnon");

            var tutor3 = new TutorStudentDal()
            {
                Number = 123456,
                LastName = "Roger"
            };
            tutorRepo.Add(tutor3);

            var sessionRepo = new EfEntityRepository<TutoringSessionDal>(dbContext);
            var tutor3FromBd = tutorRepo.GetById(tutor3.Id);
            var session1 = new TutoringSessionDal()
            {
                DateTimeSession = new DateTime(2016, 03, 16),
                LengthSession = 1,
                TutorStudentDal = tutor3FromBd
            };
            sessionRepo.Add(session1);
        }
        private static void DisplayTutorList(IQueryable<TutorStudentDal> listTutor)
        {
            Console.WriteLine("Nonbre de tuteurs: " + listTutor.Count());
            foreach (var tutor in listTutor)
            {
                Console.WriteLine(tutor.Id + " - " + tutor.Number);
            }
        }
    }
}
