using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Products.Controllers.Api;
using Products.Models;

namespace Products.Controllers
{
    public class InvoicevController : Controller
    {
        // create: Invoicev
        public ActionResult CreateInvoice()
        {
           
           
            return View();
        }

        public ActionResult GetInvoices()
        {
            return View();
        }

    }
}