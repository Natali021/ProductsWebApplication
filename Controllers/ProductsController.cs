using HW1_Products_WebApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;


namespace HW1_Products_WebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {  
        private Products myProducts = new Products();
        private readonly ILogger<ProductsController> _logger;
        public int id = 0;
        public ProductsController(ILogger<ProductsController> logger)
        {            
            _logger = logger;
        }


        [HttpGet(Name = "GetProduct")]
        public IEnumerable<Product> Get()
        {
            return Products.listProducts;
            
        }
        

        [HttpGet("{id:int}")]
        public Product? Get(int id = 1)
        {
            
            Product? item = Products.listProducts.Find(x => x.ProductId == id);
            if (item != null)
                return item;
            else return null;
        }

        //-------------- варіант без класу Products-----------------//
        ////private static readonly List<Product> myProducts = new();
        //private readonly ILogger<ProductsController> _logger;
        //public int id = 0;
        //public ProductsController(ILogger<ProductsController> logger)
        //{
        //    //myProducts.Add(new Product(1, "Goog1", 120, "Producer1", new DateTime(), "Сategory1"));
        //    //myProducts.Add(new Product(2, "Goog22", 500, "Producer22", new DateTime(), "Сategory22"));
        //    //myProducts.Add(new Product(3, "1Goog", 260, "1Producer", new DateTime(), "1Сategory"));
        //    //myProducts.Add(new Product(4, "5Goog22", 1200, "5Producer22", new DateTime(), "5Сategory22"));
        //    _logger = logger;
        //}


        //[HttpGet(Name = "GetProduct")]
        //public IEnumerable<Product> Get()
        //{
        //    return myProducts;
        //}


        //[HttpGet("{id:int}")]
        //public Product? Get(int id = 1)
        //{
        //    Product? item = myProducts.Find(x => x.ProductId == id);
        //    if (item != null)
        //        return item;
        //    else return null;
        //}



    }
}
