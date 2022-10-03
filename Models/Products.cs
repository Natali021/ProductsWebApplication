using HW1_Products_WebApplication.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace HW1_Products_WebApplication.Models
{
    public class Products
    {
        public static List<Product> listProducts = new(); 

        public Products()
        {
            listProducts.Add(new Product(1, "Goog1", 120, "Producer1", new DateTime(), "Сategory1"));
            listProducts.Add(new Product(2, "Goog22", 500, "Producer22", new DateTime(), "Сategory22"));
            listProducts.Add(new Product(3, "1Goog", 260, "1Producer", new DateTime(), "1Сategory"));
            listProducts.Add(new Product(4, "5Goog22", 1200, "5Producer22", new DateTime(), "5Сategory22"));

        }

        
    
    }
}
