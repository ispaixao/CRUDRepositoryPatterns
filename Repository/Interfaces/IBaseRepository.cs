using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security.Policy;

namespace TesteCRUDRepositoryPatterns.Repository.Interfaces
{
    public interface IBaseRepository
    {
        public void Add<T>(T entity) where T : class;
        public void Delete<T>(T entity) where T : class;
        public void Update<T>(T entity) where T : class;

    }
}
