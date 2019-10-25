using BoxConnecte.Entities;
using BoxConnecte.Mappers;
using BoxConnecte.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using Toolbox.Mapper;

namespace BoxAsp.Controllers
{
    
    public class AddressController : ApiController 
    {
        // methode api pour fair le lien a mon repository Get 
        public Address Get(int id)
        {
            AddressRepository serviceGet = new AddressRepository();
            Address p = serviceGet.Get(id).Map<Address>();
            if (p == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return p;
        }
        // methode api pour fair le lien a mon repository Insert
        public int Post(Address p)
        {

            if (ModelState.IsValid)
            {
                AddressRepository repo = new AddressRepository();
                return repo.Insert(p.Map<Address>());
            }
            throw new HttpResponseException(HttpStatusCode.BadRequest);
        }

        // methode api pour fair le lien a mon repository delete
        public bool Delete(int id)
        {
            AddressRepository repo = new AddressRepository();
            try
            {
                return repo.Delete(id);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }
        // methode api pour fair le lien a mon repository modifier
        public bool Put(Address p)
        {
            AddressRepository repo = new AddressRepository();
            if (ModelState.IsValid)
            {
                try
                {
                    return repo.Update(p.Map<Address>());
                }
                catch (Exception)
                {
                    throw new HttpResponseException(HttpStatusCode.NotFound);
                }
            }
            throw new HttpResponseException(HttpStatusCode.BadRequest);
        }

    }
}