using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Products.Controllers.Api
{
    public class MyInvoiceController : ApiController
    {
        Products_DBEntities2 _context;

        public MyInvoiceController()
        {
            _context = new Products_DBEntities2();
        }

        //to eliminate all unused resources
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public IHttpActionResult GetInvoices()
        {
            return Ok(_context.Invoices.ToList());
        }

        [HttpPost]
        public IHttpActionResult CreateInvoice(Invoice inv)
        {
            if ((!ModelState.IsValid) || inv.Net == 0 || inv.Taxes == 0 || inv.Total == 0 || inv.Invoice_Date == DateTime.MinValue)
                return BadRequest("Please Check your data");


            _context.Invoices.Add(inv);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + inv.ID), inv);
        }
    }
}
