#region using
using System;
#endregion

namespace DataLayer.Entities
{
    public class TutoringSessionDal : EntityDal
    {
        public DateTime DateTimeSession { get; set; }
        public int LengthSession { get; set; }

        public virtual TutorStudentDal TutorStudentDal { get; set; }
    }
}
