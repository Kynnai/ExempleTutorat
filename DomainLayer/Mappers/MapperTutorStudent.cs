#region using
using DataLayer.Entities;
using DomainLayer.Tutor;
#endregion

namespace DomainLayer.Mappers
{
    public static class MapperTutorStudent
    {
        public static TutorStudentDal Map(TutorStudent entityDal)
        {
            return new TutorStudentDal()
            {
                Id = entityDal.Id,
                Number = entityDal.Number,
                LastName = entityDal.LastName
            };
        }

       public static TutorStudent Map(TutorStudentDal entityStudent)
        {
            return new TutorStudent()
            {
                Id = entityStudent.Id,
                Number = entityStudent.Number,
                LastName = entityStudent.LastName
            };
        }
    }
}
