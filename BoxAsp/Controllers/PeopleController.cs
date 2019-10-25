using BoxConnecte.Entities;
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
    public class PeopleController : ApiController
    {
        public People Get(int id)
        {
            PeopleRepository serviceGet = new PeopleRepository();
            People p = serviceGet.Get(id).Map<People>();
            if (p == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return p;
        }
        public int Post(People p)
        {

            if (ModelState.IsValid)
            {
                PeopleRepository repo = new PeopleRepository();
                return repo.Insert(p.Map<People>());
            }
            throw new HttpResponseException(HttpStatusCode.BadRequest);
        }
        public bool Delete(int id)
        {
            PeopleRepository repo = new PeopleRepository();
            try
            {
                return repo.Delete(id);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        [HttpPut]
        public bool Put( People p)
        {
            PeopleRepository repo = new PeopleRepository();
            if (ModelState.IsValid)
            {
                try
                {
                    
                    return repo.Update(p.Map<People>());
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