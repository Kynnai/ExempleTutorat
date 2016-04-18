using DataLayer.Entities;
using System.Linq;

namespace DataLayer.Interface
{
    public interface IRepository<T> where T:EntityDal
    {
        T GetById(int id);

        IQueryable<T> GetAll();

        void Add(T tutor);

        void Update(T tutor);

        void Delete(T tutor);

        void DeleteAll();
    }
}
