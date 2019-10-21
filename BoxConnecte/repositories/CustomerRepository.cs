using BoxConnecte.Entities;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.repositories
{
    public class CustomerRepository : BaseRepository<Customer>
    {
        public override bool Delete(int id)
        {
            string query = "DELETE FROM customer WHERE Id = @Id";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Id", id);
            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        public override Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public override int Insert(Customer customer)
        {
            string query = " INSERT INTO (Number,Street,PostalCode,City)OUTPUT inserted.id VALUES (@Number,@Street,@PostalCode,@City)";
            Command cmd = new Command(query);
            //setParameters est une methode pour des valeurs economie de ligne de code  
            cmd.SetParameters(customer);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(Customer customer)
        {
            string query = "UPDATE Customer SET CustomerCode = @CustomerCode";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Number", customer.CustomerCode);
            
            return (_Connection.ExecuteNonQuery(cmd) == 1);
        }
    }
}
