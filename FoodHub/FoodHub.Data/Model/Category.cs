using FoodHub.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodHub.Data.Model
{
    public class Category
    {
        public object getAllCategories()
        {
            using (var db = new FoodHubEFModel())
            {
                try
                {
                    var data = (from mc in db.MasterCategory
                                select new
                                {
                                    CategoryId = mc.CategoryId,
                                    CategoryName = mc.CategoryName,
                                    DefaultImageURL = mc.DefaultImageURL,
                                    IsActive = mc.IsActive
                                }).ToList();

                    if (data.Count > 0)
                    {
                        return data;
                    }
                    return "";
                }
                catch (Exception ex)
                {
                    return "";
                }
            }
        }

    }
}
