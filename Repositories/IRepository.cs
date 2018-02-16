using System.Collections.Generic;

namespace WebAPI.Repositories
{
    public interface IRepository<T>
    {
		void Add(T obj);
		IEnumerable<T> FindAll();
		T Find(long id);
		void Remove(long id);
		void Update(long id, T obj);
		void Save();
    }
}
