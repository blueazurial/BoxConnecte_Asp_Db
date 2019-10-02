using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.Entities
{
    class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int QrCode { get; set; }
        public int DigiCode { get; set; }
        public DateTime DateDelivery { get; set; }
        public DateTime DateLimite { get; set; }
        public int CustumerId { get; set; }
        public int SellerId { get; set; }
        public int OrderStatusId { get; set; }
    }
}
