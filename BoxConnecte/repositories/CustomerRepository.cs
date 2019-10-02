using BoxConnecte.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.repositories
{
    class CustomerRepository : BaseRepository<Customer>
    {
        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public override int Insert(Customer entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
