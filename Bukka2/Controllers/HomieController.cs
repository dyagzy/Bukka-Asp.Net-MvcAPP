using Bukka2.Models;
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
        private BukkaDbEntities _objBukkaDbEntities;
        public HomieController()
        {
            _objBukkaDbEntities = new BukkaDbEntities();
        }
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

        [HttpGet]
        public JsonResult getItemUnitPrice(int foodId)
        {
          decimal unitPrice = _objBukkaDbEntities.Foods.SingleOrDefault(model => model.FoodId == foodId).FoodPrice;

            return Json(unitPrice, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {

        }
    }
}