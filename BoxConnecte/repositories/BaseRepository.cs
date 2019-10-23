using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.repositories
{
    public abstract class  BaseRepository<T>
    {
        protected Connection _Connection;

        public BaseRepository()
        {
            _Connection = new Connection("Data Source=TECHNOBEL;Initial Catalog=DbBOX;User ID=sa;Password=test1234=;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False", "System.Data.SqlClient");
        }
        public abstract T Get(int id);

        public abstract IEnumerable<T> GetAll();

        public abstract int Insert(T entity);

        public abstract bool Update(T entity);

        public abstract bool Delete(int id);
    }
}
