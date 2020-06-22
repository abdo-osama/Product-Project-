using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Products.Controllers.Api
{
    public class StoreController : ApiController
    {
        Products_DBEntities2 _context;

        public StoreController()
        {
            _context = new Products_DBEntities2();
        }

        //to eliminate all unused resources
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public List<Store> GetStores()
        {
            return _context.Stores.ToList();
        }
    }
}
