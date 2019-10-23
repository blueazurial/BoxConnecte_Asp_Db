using BoxConnecte.Entities;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.repositories
{
    class OrderRepository : BaseRepository<Order>
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
            throw new NotImplementedException();
        }

        public override IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public override int Insert(Order order)
        {
            string query = " INSERT INTO order(Description,QrCode,PswBox,OrderWithdrawn,NumberBox)OUTPUT inserted.id VALUES (@description,@qrcode,@pswBox,@orderwithdrawn,@numberbox)";
            Command cmd = new Command(query);
            //setParameters est une methode pour des valeurs economie de ligne de code  
            cmd.SetParameters(order);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(Order order)
        {
            string query = "UPDATE Address SET Description = @Description, QrCode = @QrCode,PswBox = @pswbox,OrderWithdrawn = @orderwithdrawn,NumberBox = @NumberBox";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Description", order.Description);
            cmd.Parameters.Add("@QrCode", order.QrCode);
            cmd.Parameters.Add("@PswBox", order.PswBox);
            cmd.Parameters.Add("@OrderWithdrawn", order.OrderWithdrawn);
            cmd.Parameters.Add("@NumberBox", order.NumberBox);

            return (_Connection.ExecuteNonQuery(cmd) == 1);
        }
    }
}
