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
            string query = "DELETE FROM People WHERE ID = @Id";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Id", id);
            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        public override People Get(int id)
        {
            string query = "SELECT ID,C_Nom,LastName,Email,Birthdate,Gsm ,AddressId,' ' as [Password] FROM People WHERE ID = @id";
            Command cmd = new Command(query);
            cmd.AddParameter("@id", id);
            return _Connection.ExecuteReader(cmd, UniversalDbToEntityMapper.Mapper<People>).FirstOrDefault();
        }

        public override IEnumerable<People> GetAll()
        {
            throw new Exception();
        }

        public override int Insert(People people)
        {
            string query = "SP_Register";
            Command cmd = new Command(query, true );
            //setParameters est une methode pour des valeurs economie de ligne de code  
            cmd.SetParameters(people);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(People people)
        {
            string query = "UPDATE People SET C_Nom = @c_nom,LastName = @LastName,Email = @Email,Birthdate = @Birthdate,Gsm = @Gsm,[Password] = dbo.Udf_Hash_Password(@password,@email),AddressId = @addressid WHERE ID = @id";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@id", people.ID);
            cmd.Parameters.Add("@c_nom", people.C_Nom);
            cmd.Parameters.Add("@lastName", people.LastName);
            cmd.Parameters.Add("@email", people.Email);
            cmd.Parameters.Add("@birthdate", people.Birthdate);
            cmd.Parameters.Add("@gsm", people.Gsm);
            cmd.Parameters.Add("@password", people.Password);
            cmd.Parameters.Add("@addressid", people.AddressId);
            return (_Connection.ExecuteNonQuery(cmd) == 1);
        }
    }
}
