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
    public class OrderController : ApiController
    {
        public Order Get(int id)
        {
            OrderRepository serviceGet = new OrderRepository();
            Order p = serviceGet.Get(id).Map<Order>();
            if (p == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return p;
        }
        public int Post(Order p)
        {

            if (ModelState.IsValid)
            {
                OrderRepository repo = new OrderRepository();
                return repo.Insert(p.Map<Order>());
            }
            throw new HttpResponseException(HttpStatusCode.BadRequest);
        }
        public bool Delete(int id)
        {
            OrderRepository repo = new OrderRepository();
            try
            {
                return repo.Delete(id);
            }
            catch (Exception)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        public bool Put(int id, Order p)
        {
            OrderRepository repo = new OrderRepository();
            if (ModelState.IsValid)
            {
                try
                {
                    p.ID = id;
                    return repo.Update(p.Map<Order>());
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