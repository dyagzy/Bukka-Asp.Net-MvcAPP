using Bukka2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bukka2.Repository.Service
{
    public class CustomerRepository
    {
        private BukkaDbEntities _objBukkaDbEntities;
        public CustomerRepository()
        {

            _objBukkaDbEntities = new BukkaDbEntities();
        }
        public IEnumerable<SelectListItem> GetAllCustomer()
        {
            var customerList = new List<SelectListItem>();

            customerList = (from customer in _objBukkaDbEntities.Customers
                        select new SelectListItem()
                        {
                            Text = customer.CustomerName,
                            Value = customer.CustoemrId.ToString(),
                            Selected = true

                        }).ToList();


            return customerList;
        }
    }
}