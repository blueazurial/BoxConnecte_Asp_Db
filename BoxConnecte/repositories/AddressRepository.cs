using BoxConnecte.Attributes;
using BoxConnecte.Entities;
using BoxConnecte.Mappers;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.repositories
{
    class AddressRepository : BaseRepository<Address>
    {
        public override bool Delete(int id)
        {
            string query = "DELETE FROM Address WHERE Id = @Id";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Id", id);
            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        public override Address Get(int id)
        {
            string query = "SELECT * FROM Address WHERE Id = @id";
            Command cmd = new Command(query);
            cmd.AddParameter("@id", id);
            return _Connection.ExecuteReader(cmd, UniversalDbToEntityMapper.Mapper<Address>).FirstOrDefault();
        }

        public override IEnumerable<Address> GetAll()
        {
            string query = "SELECT * FROM Address ";
            Command cmd = new Command(query);
            //executeR me renvoie un idatareader et mon mapper fais les liens vers mon object 
            return _Connection.ExecuteReader(cmd, UniversalDbToEntityMapper.Mapper<Address>);
        }

        public override int Insert(Address address)
        {
            string query = " INSERT INTO Address(Number,Street,PostalCode,City)OUTPUT inserted.id VALUES (@Number,@Street,@PostalCode,@City)";
            Command cmd = new Command(query);
            //setParameters est une methode pour des valeurs economie de ligne de code  
            cmd.SetParameters(address);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(Address address)
        {
            string query = "UPDATE Address SET Number = @Number,Street = @Street,PostalCode = @PostalCode,City = @City";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Number", address.Number);
            cmd.Parameters.Add("@Street", address.Street);
            cmd.Parameters.Add("@PostalCode", address.PostalCode);
            cmd.Parameters.Add("@City", address.City);
            return (_Connection.ExecuteNonQuery(cmd) == 1);

        }
    }
}
