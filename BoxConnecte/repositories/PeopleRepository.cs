
using BoxConnecte.Entities;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.repositories
{
    class PeopleRepository : BaseRepository<People>
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
            throw new NotImplementedException();
        }

        public override IEnumerable<People> GetAll()
        {
            throw new NotImplementedException();
        }

        public override int Insert(People people)
        {
            string query = " INSERT INTO People(FirstName,LastName,Email,Birthdate,Gsm,Password)OUTPUT inserted.id VALUES (@FirstName,@LastName,@Email,@Birthdate,@Gsm,@password)";
            Command cmd = new Command(query);
            //setParameters est une methode pour des valeurs economie de ligne de code  
            cmd.SetParameters(people);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(People people)
        {
            string query = "UPDATE people SET C_Nom = @c_nom,LastName = @LastName,Email = @Email,Birthdate = @Birthdate,Gsm = @Gsm ,Password = @password";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@c_nom", people.C_Nom);
            cmd.Parameters.Add("@LastName", people.LastName);
            cmd.Parameters.Add("@Email", people.Email);
            cmd.Parameters.Add("@Birthdate", people.Birthdate);
            cmd.Parameters.Add("@Gsm", people.Gsm);
            cmd.Parameters.Add("@Password", people.Password);
            return (_Connection.ExecuteNonQuery(cmd) == 1);
        }
    }
}
