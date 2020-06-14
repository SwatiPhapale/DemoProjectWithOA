using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        //private readonly IProductService _repo;

        public HomeController(IProductService repo)
        {
            //_repo = repo;
        }

        [HttpGet("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
           // var products = _repo.GetAllProduct();
            return Ok("OK");
        }

        [HttpGet]
        public IActionResult GetProductById(int Id)
        {
           // var product = _repo.GetProductById(Id);
            return Ok("");
        }
    }
}
