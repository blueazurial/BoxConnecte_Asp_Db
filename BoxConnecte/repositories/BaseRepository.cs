using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.repositories
{
    public abstract class  BaseRepository<T>
    {
        public abstract T Get(int id);

        public abstract IEnumerable<T> GetAll();

        public abstract int Insert(T entity);

        public abstract bool Update(T entity);

        public abstract bool Delete(int id);
    }
}
