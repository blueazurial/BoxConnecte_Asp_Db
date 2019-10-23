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
    public class OrderRepository : BaseRepository<Order>
    {
        public override bool Delete(int id)
        {
            string query = "DELETE FROM Order WHERE ID = @Id";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Id", id);
            return _Connection.ExecuteNonQuery(cmd) == 1;
        }

        public override Order Get(int id)
        {
            string query = "SELECT * FROM Order WHERE ID = @id";
            Command cmd = new Command(query);
            cmd.AddParameter("@id", id);
            return _Connection.ExecuteReader(cmd,UniversalDbToEntityMapper.Mapper<Order>).FirstOrDefault(); ;
        }

        public override IEnumerable<Order> GetAll()
        {
            string query = "SELECT * FROM Order ";
            Command cmd = new Command(query);
            //executeR me renvoie un idatareader et mon mapper fais les liens vers mon object 
            return _Connection.ExecuteReader(cmd, UniversalDbToEntityMapper.Mapper<Order>);
        }

        public override int Insert(Order order)
        {
            string query = " INSERT INTO Order(Description,QrCode,PswBox,OrderWithdrawn,NumberBox) OUTPUT inserted.id VALUES (@description,@qrcode,@pswBox,@orderwithdrawn,@numberbox)";
            Command cmd = new Command(query);  
            cmd.SetParameters(order);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(Order order)
        {
            string query = "UPDATE Address SET Description = @Description, QrCode = @QrCode,PswBox = @pswbox,OrderWithdrawn = @orderwithdrawn,NumberBox = @NumberBox WHERE ID = @id";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@id", order.ID);
            cmd.Parameters.Add("@Description", order.Description);
            cmd.Parameters.Add("@QrCode", order.QrCode);
            cmd.Parameters.Add("@PswBox", order.PswBox);
            cmd.Parameters.Add("@OrderWithdrawn", order.OrderWithdrawn);
            cmd.Parameters.Add("@NumberBox", order.NumberBox);

            return (_Connection.ExecuteNonQuery(cmd) == 1);
        }
    }
}
