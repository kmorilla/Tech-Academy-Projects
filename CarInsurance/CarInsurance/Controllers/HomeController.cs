using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;
using CarInsurance.ViewModels;

namespace CarInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult InsuranceQuote(string firstName, string lastName, string dateOfBirth, string emailAddress, string carMake, string carModel, string carYear, string coverage, string dui, string speedingTickets)
        {
            decimal baseQuote = 50m;

            DateTime newBirthDay = Convert.ToDateTime(dateOfBirth);
            DateTime todayDate = DateTime.Today;
            int age = todayDate.Year - newBirthDay.Year;
            if (newBirthDay > todayDate.AddYears(-age))
            {
                age--;
            }
            if (age < 25) baseQuote += 25;
            if (age < 18) baseQuote += 100;
            if (age > 100) baseQuote += 25;

            int newCarYear = Convert.ToInt32(carYear);
            if (newCarYear < 2000) baseQuote += 25;
            if (newCarYear > 2015) baseQuote += 25;

            if (carMake == "Porsche") baseQuote += 25;
            if (carModel == "911 Carrera") baseQuote += 25;

            int tickets = Convert.ToInt32(speedingTickets);
            for (int i = 0; i < tickets; i++)
            {
                baseQuote += 10;
            }

            if (dui == "Yes") baseQuote += (baseQuote * .25m);

            if (coverage == "Full Coverage") baseQuote += (baseQuote * .5m);
                       
            using (CarInsuranceQuotesEntities db = new CarInsuranceQuotesEntities())
            {
                var quote = new CarInsuraceQuote();
                quote.FirstName = firstName;
                quote.LastName = lastName;
                quote.DateOfBirth = dateOfBirth;
                quote.EmailAddress = emailAddress;
                quote.CarMake = carMake;
                quote.CarModel = carModel;
                quote.CarYear = Convert.ToInt32(carYear);
                quote.Coverage = coverage;
                quote.DUI = dui;
                quote.SpeedingTickets = Convert.ToInt32(speedingTickets);
                quote.VehicleQuote = Convert.ToInt32(baseQuote);

                db.CarInsuraceQuotes.Add(quote);
                db.SaveChanges();
            }

            return View("Success");

        }
    }
}