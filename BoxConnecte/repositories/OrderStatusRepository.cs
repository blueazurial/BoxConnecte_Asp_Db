using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxConnecte.Entities;

namespace BoxConnecte.repositories
{
    public class OrderStatusRepository : BaseRepository<OrderStatus>
    {
        public override bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public override OrderStatus Get(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<OrderStatus> GetAll()
        {
            throw new NotImplementedException();
        }

        public override int Insert(OrderStatus entity)
        {
            throw new NotImplementedException();
        }

        public override bool Update(OrderStatus entity)
        {
            throw new NotImplementedException();
        }
    }
}
