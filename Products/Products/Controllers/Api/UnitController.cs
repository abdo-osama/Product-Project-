using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Products.Controllers.Api
{
    public class UnitController : ApiController
    {

        Products_DBEntities2 _context;

        public UnitController()
        {
            _context = new Products_DBEntities2();
        }

        //to eliminate all unused resources
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public List<Unit> GetUnits()
        {
            return _context.Units.ToList();
        }

        [HttpDelete]
        public IHttpActionResult DeleteUnit(int id)
        {
          var unit = _context.Units.SingleOrDefault(s => s.ID == id);

            if (unit == null)
                return BadRequest("The unit is not existed");

            _context.Units.Remove(unit);
            return Ok(_context.Units.ToList());
        }
    }
}
