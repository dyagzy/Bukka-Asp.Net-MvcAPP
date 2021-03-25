using Bukka2.Repository.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bukka2.Controllers
{
    public class HomieController : Controller
    {
        // GET: Homie
        public ActionResult Index()
        {
            CustomerRepository _customerRepo = new CustomerRepository();
            FoodRepository _foodRepo = new FoodRepository();
            PaymentTypeRepository _paymentRepo = new PaymentTypeRepository();


            var objMultiple = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (_customerRepo.GetAllCustomer(), _foodRepo.GetAllFood(), _paymentRepo.GetAllPaymentType());

            return View(objMultiple);
           

        }

        protected override void Dispose(bool disposing)
        {

        }
    }
}