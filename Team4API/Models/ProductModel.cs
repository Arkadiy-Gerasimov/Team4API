using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Team4API.Models
{
    public class ProductModel
    {       
        public int _ID_product { get; set; }
        public string _title { get; set; }
        public int _ID_category { get; set; }
        
        public ProductModel(Product pm)
        {
            _ID_product = pm.ID_product;
            _title = pm.title;
            _ID_category = pm.ID_category;           
        }
    }
}