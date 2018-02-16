using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class GenericRepository<T> where T : class
	{
		private WebAPIContext context;

		public GenericRepository(WebAPIContext context)
		{
			this.context = context;
		}

		public void Add(T obj)
		{
			context.Set<T>().Add(obj);
			Save();
		}

		public void Remove(long id)
		{
			var obj = Find(id);
			context.Set<T>().Remove(obj);
			Save();
		}

		public void Update(long id, T obj)
		{
			context.Entry(obj).State = EntityState.Modified;
            Save();
		}

		public T Find(long id)
		{
			return context.Set<T>().Find(id);
		}

		public IEnumerable<T> FindAll()
		{
			return context.Set<T>().ToList();
		}

		public void Save()
		{
			context.SaveChanges();
		}
	}
}
