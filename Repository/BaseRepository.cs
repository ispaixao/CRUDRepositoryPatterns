using TesteCRUDRepositoryPatterns.Data;
using TesteCRUDRepositoryPatterns.Repository.Interfaces;

namespace TesteCRUDRepositoryPatterns.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private AppDbContext _context;
        public BaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
            _context.SaveChanges();
        }
    }
}
