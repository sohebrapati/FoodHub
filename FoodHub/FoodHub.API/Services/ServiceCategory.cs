using FoodHub.API.Dtos;
using FoodHub.Data.Model;
using Newtonsoft.Json;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.API.Services
{
    public class CategoryService : Service
    {
        public object Any(Categories request)
        {
            Category obj = new Category();
            var response = obj.getAllCategories();
            return JsonConvert.SerializeObject(response);
        }
    }
}
