#region using
using System.Data.Entity;
using System.Linq;
using DataLayer.Entities;
using DataLayer.Interface;
#endregion

namespace DataLayer.EntityFramework
{
    public class EfEntityRepository<T>:IRepository<T> where T:EntityDal
    {
        private readonly DbContext _context;

        public EfEntityRepository(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            //return _context.Tutors.AsQueryable();
            return _context.Set<T>().AsQueryable();
        }

        public T GetById(int id)
        {
            //return _context.Tutors.FirstOrDefault(t => t.Id == id);
            return _context.Set<T>().FirstOrDefault(t => t.Id == id);
        }

        public void Add(T tutor)
        {
            //_context.Tutors.Add(tutor);
            _context.Set<T>().Add(tutor);
            _context.SaveChanges();
        }

        public void Update(T tutor)
        {
            _context.Set<T>().Attach(tutor);
            _context.Entry(tutor).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T tutor)
        {
            _context.Set<T>().Remove(tutor);
            _context.SaveChanges();
        }

        public void DeleteAll()
        {
            _context.Set<T>().RemoveRange(_context.Set<T>());
            _context.SaveChanges();
        }
}
}
