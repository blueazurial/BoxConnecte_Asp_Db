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
            string query = "DELETE FROM Order WHERE Id = @Id";
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
            string query = " INSERT INTO order(Description,QrCode,DigiCode,DateDelivery,DateLimite,CustumerId,SellerId,OrderStatusId)OUTPUT inserted.id VALUES (@Description,@QrCode,@DigiCode,@DateDelivery,@DateLimite,@CustumerId,@SellerId,@OrderStatusId)";
            Command cmd = new Command(query);
            //setParameters est une methode pour des valeurs economie de ligne de code  
            cmd.SetParameters(order);

            return (int)_Connection.ExecuteScalar(cmd);
        }

        public override bool Update(Order order)
        {
            string query = "UPDATE Address SET Description = @Description, QrCode = @QrCode,DigiCode = @DigiCode,DateDelivery = @DateDelivery,DateLimite = @DateLimite,CustumerId = @CustumerId,SellerId = @SellerId,OrderStatusId = @OrderStatusId";
            Command cmd = new Command(query);
            cmd.Parameters.Add("@Description", order.Description);
            cmd.Parameters.Add("@QrCode", order.QrCode);
            cmd.Parameters.Add("@DigiCode", order.DigiCode);
            cmd.Parameters.Add("@DateDelivery", order.DateDelivery);
            cmd.Parameters.Add("@DateLimite", order.DateLimite);
            cmd.Parameters.Add("@CustumerId", order.CustumerId);
            cmd.Parameters.Add("@SellerId", order.SellerId);
            cmd.Parameters.Add("@OrderStatusId", order.OrderStatusId);
            return (_Connection.ExecuteNonQuery(cmd) == 1);
        }
    }
}
