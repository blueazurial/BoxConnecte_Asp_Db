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
    public class PeopleRepository : BaseRepository<People>
    {
        public override bool Delete(int id)
        {
            string query = "DELETE FROM People WHERE Id = @Id";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Id", id);
            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        public override People Get(int id)
        {
            string query = "SELECT * FROM People WHERE Id = @id";
            Command cmd = new Command(query);
            cmd.AddParameter("@id", id);
            return _Connection.ExecuteReader(cmd, UniversalDbToEntityMapper.Mapper<People>).FirstOrDefault();
        }

        public override IEnumerable<People> GetAll()
        {
            string query = "SELECT * FROM People ";
            Command cmd = new Command(query);
            //executeR me renvoie un idatareader et mon mapper fais les liens vers mon object 
            return _Connection.ExecuteReader(cmd, UniversalDbToEntityMapper.Mapper<People>);
        }

        public override int Insert(People people)
        {
            string query = " INSERT INTO People(FirstName,LastName,Email,Birthdate,Gsm,AddressId)OUTPUT inserted.id VALUES (@firstName,@lastName,@email,@birthdate,@gsm,@addressId)";
            Command cmd = new Command(query);
            //setParameters est une methode pour des valeurs economie de ligne de code  
            cmd.SetParameters(people);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(People people)
        {
            string query = "UPDATE people SET FirstName = @FirstName,LastName = @LastName,Email = @Email,Birthdate = @Birthdate,Gsm = @Gsm ";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@firstName", people.FirstName);
            cmd.Parameters.Add("@lastName", people.LastName);
            cmd.Parameters.Add("@email", people.Email);
            cmd.Parameters.Add("@birthdate", people.Birthdate);
            cmd.Parameters.Add("@gsm", people.Gsm);
            return (_Connection.ExecuteNonQuery(cmd) == 1);
        }
    }
}
