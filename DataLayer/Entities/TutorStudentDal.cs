
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public sealed class TutorStudentDal : EntityDal
    {
        public int Number { get; set; }

        public string LastName { get; set; }

        public ICollection<TutoringSessionDal> SessionDals { get; set; }

        public TutorStudentDal()
        {
            SessionDals = new List<TutoringSessionDal>();
        }
    }
}
