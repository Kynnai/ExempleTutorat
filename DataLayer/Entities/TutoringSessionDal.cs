#region using
using System;
#endregion

namespace DataLayer.Entities
{
    public class TutoringSessionDal : EntityDal
    {
        public DateTime DateTimeSession { get; set; }
        public int LengthSession { get; set; }

        /// <summary>
        /// Foreign Key
        /// </summary>
        /// [ForeignKey("TutorStudentDal")]
        public int TutorStudentDalId { get; set; }

        /// <summary>
        /// Navigagion Properties
        /// </summary>
        ///[ForeignKey("StandardRefId")]
        public virtual TutorStudentDal TutorStudentDal { get; set; }
    }
}
