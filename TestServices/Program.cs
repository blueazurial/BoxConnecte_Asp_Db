using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoxConnecte.Entities;
using BoxConnecte.repositories;

namespace TestServices
{
    class Program
    {
        static void Main(string[] args)
        {
            PeopleRepository insertPersonne1 = new PeopleRepository();
            People personne1 = new People();
            personne1.FirstName = "Maud";
            personne1.LastName = "de Goes";
            personne1.Gsm = 0475826809;
            personne1.Email = "maud@hotmail.com";
            personne1.Birthdate = new DateTime(14 / 05 / 1995);
            AddressRepository insertaddress1 = new AddressRepository();
            Address address1 = new Address();
            address1.City = "Esneux";


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
