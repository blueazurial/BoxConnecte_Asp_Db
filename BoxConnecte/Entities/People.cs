using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxConnecte.Entities
{
    public class People
    {
        public int ID { get; set; }
        public string C_Nom { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gsm { get; set; }
        public int AddressId { get; set; }
        public string Password { get; set; }
    }
}
