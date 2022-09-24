using Simply.DAL;
using Simply.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Simply.Controllers
{
    public class HomeController : Controller
    {

        private SimplyContext _context = new SimplyContext();

        public HomeController()
        {

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Review()
        {
            ViewBag.Message = "Your review page.";

            return View();
        }

        [HttpPost]
        public ActionResult Review(Customer customer)
        {

            ViewBag.Message = "Your review page.";

            customer.CreatedDate = DateTime.UtcNow;

            Customer newCustomer = new Customer();

            _context.Customer.Add(customer);
            _context.SaveChanges();

            return View("ReviewShare");
        }

        public ActionResult Share()
        {
            ViewBag.Message = "Your share page.";

            return View();
        }

        [HttpPost]
        public ActionResult Share(ReferralCustomer refCustomer)
        {
            ViewBag.Message = "Your Referral page page.";

            refCustomer.CreatedDate = DateTime.UtcNow;

            ReferralCustomer newCustomer = new ReferralCustomer();

            _context.ReferralCustomer.Add(refCustomer);
            _context.SaveChanges();

            return View("Voucher");

        }
    }
}