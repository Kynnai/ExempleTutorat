#region using
using System.Data.Entity;
using DataLayer.Entities;
#endregion

namespace DataLayer.EntityFramework
{
    public class EfTutoringDbContext : DbContext
    {
        public DbSet<TutorStudentDal> Tutors { get; set; }
        //public DbSet<TutoringSessionDal> Sessions { get; set; }

        public EfTutoringDbContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<EfTutoringDbContext>());
        }
    }
}