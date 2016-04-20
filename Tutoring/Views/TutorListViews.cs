#region using
using System;
using System.Collections.Generic;
using Tutoring.ViewObjects;
#endregion

namespace Tutoring.Views
{
    public class TutorListViews
    {
        private readonly IEnumerable<TutorListVO> _tutorList;

        public TutorListViews(IEnumerable<TutorListVO> tutorList)
        {
            _tutorList = tutorList;
        }

        public void Display()
        {
            Console.WriteLine("Liste des tuteurs");
            foreach (var tutor in _tutorList)
            {
                Console.WriteLine(tutor.Number + " - " + tutor.LastName);
            }
        }
    }
}
