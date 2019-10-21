using BoxConnecte.Entities;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.repositories
{
    public class BoxStatusRepository : BaseRepository<BoxStatus>
    {
        public override bool Delete(int id)
        {
            string query = "DELETE FROM BoxeStatus WHERE Id = @Id";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Id", id);
            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        public override BoxStatus Get(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<BoxStatus> GetAll()
        {
            throw new NotImplementedException();
        }

        public override int Insert(BoxStatus boxeStatus)
        {
            throw new NotImplementedException();
        }

        public override bool Update(BoxStatus entity)
        {
            throw new NotImplementedException();
        }
    }
}
