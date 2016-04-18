
using System.Collections.Generic;

namespace DataLayer.Entities
{
    public class TutorStudentDal : EntityDal
    {
        public int Number { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<TutoringSessionDal> SessionDals { get; set; }

        public TutorStudentDal()
        {
            SessionDals = new List<TutoringSessionDal>();
        }
    }
}
