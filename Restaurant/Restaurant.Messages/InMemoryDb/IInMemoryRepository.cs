using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Messages.InMemoryDb
{
    public interface IInMemoryRepository<T> where T : class
    {
        public void AddOrUpdate(T entity);

        public IEnumerable<T> Get();
    }
}
