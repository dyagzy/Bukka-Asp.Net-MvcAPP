using Bukka2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bukka2.Repository.Service
{
    public class PaymentTypeRepository
    {
        private BukkaDbEntities _objBukkaDbEntities;
        public PaymentTypeRepository()
        {

            _objBukkaDbEntities = new BukkaDbEntities();
        }
        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            var paymentList = new List<SelectListItem>();

            paymentList = (from payment in _objBukkaDbEntities.PaymentTypes
            select new SelectListItem()
            {
                Text = payment.PaymentTypeName,
                Value = payment.PaymentTypeId.ToString(),
                Selected = true

            }).ToList();


            return paymentList;
        }
    }
}