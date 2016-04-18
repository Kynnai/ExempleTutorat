
namespace DomainLayer.Tutor
{
    public class TutorStudent
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string LastName { get; set; }
        //public ICollextion<TutoringSession> Sessions { get; set; }

        public int GetTutoringHours()
        {
            return 0;
        }
    }
}
