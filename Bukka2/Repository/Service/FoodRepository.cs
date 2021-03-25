using Bukka2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bukka2.Repository.Service
{
    public class FoodRepository
    {
        private BukkaDbEntities _objBukkaDbEntities;
        public FoodRepository()
        {

            _objBukkaDbEntities = new BukkaDbEntities();
        }
        public IEnumerable<SelectListItem> GetAllFood()
        {
            var foodList = new List<SelectListItem>();

            foodList = (from food in _objBukkaDbEntities.Foods
                           select new SelectListItem()
                           {
                               Text = food.FoodName,
                               Value = food.FoodId.ToString(),
                               Selected = true

                           }).ToList();


            return foodList;
        }
    }
}
