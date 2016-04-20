#region using
using TestUtility;
using Tutoring.Controllers;

#endregion

namespace Tutoring
{
    public class Program
    {
        private static void Main(/*string[] args*/)
        {
            var seeder = new TestDataSeeder();
            seeder.ClearTables();
            seeder.SeedTables();

            var tutorController = new TutorController();
            tutorController.ListAll();
        }
    }
}
