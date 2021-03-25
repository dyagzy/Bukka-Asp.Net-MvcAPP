using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUKKA.Repository.Service
{
    public class PaymentTypeRepository
    {
        private RestaurantModel objRestaurantDbEntities;
        public PaymentTypeRepository()
        {
            var n = new RestaurantModel();
        }
    }
}