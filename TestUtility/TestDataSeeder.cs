#region using
using System.Data.Entity;
using DataLayer.Entities;
using DataLayer.EntityFramework;
using DataLayer.Interface;
#endregion

namespace TestUtility
{
    public class TestDataSeeder
    {
        private readonly IRepository<TutorStudentDal> _tutoRepository;
        public TestDataSeeder()
        {
            DbContext appContext = new EfTutoringDbContext();
            _tutoRepository = new EfEntityRepository<TutorStudentDal>(appContext);

        }

        public void ClearTables()
        {
            _tutoRepository.DeleteAll();
        }

        public void SeedTables()
        {
            _tutoRepository.Add(new TutorStudentDal()
            {
                Number = 12345,
                LastName = "Toto"
            });
        }
    }
}
