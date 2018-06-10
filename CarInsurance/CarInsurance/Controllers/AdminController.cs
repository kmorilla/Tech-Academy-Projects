using CarInsurance.Models;
using CarInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (CarInsuranceQuotesEntities db = new CarInsuranceQuotesEntities())
            {
                var quotes = new List<CarInsuraceQuote>();
                var quoteVms = new List<AdminVm>();
                foreach (var quote in quotes)
                {
                    var quoteVm = new AdminVm();
                    quoteVm.FirstName = quote.FirstName;
                    quoteVm.LastName = quote.LastName;
                    quoteVm.EmailAddress = quote.EmailAddress;
                    quoteVm.VehicleQuote = quote.VehicleQuote;
                    quoteVms.Add(quoteVm);
                }

                return View(quoteVms);
            }
        }
    }
}