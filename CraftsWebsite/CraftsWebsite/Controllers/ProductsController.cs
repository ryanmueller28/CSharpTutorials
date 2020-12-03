using CraftsWebsite.Models;
using CraftsWebsite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CraftsWebsite.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductsService productsService)
        {
            this.ProductsService = productsService;
        }

        public JsonFileProductsService ProductsService { get; }
        
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductsService.GetProducts();
        }


        [HttpPatch]
        public ActionResult Get([FromBody] RatingRequest request)
        {
            ProductsService.AddRating(request.ProductId, request.Rating);
            return Ok();
        }

        public class RatingRequest
        {
            public string ProductId{ get; set; }
            public int Rating { get; set; }
        }

    }
}
