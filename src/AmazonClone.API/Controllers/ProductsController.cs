using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonClone.DbContexts;
using AmazonClone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AmazonClone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        ApplicationDbContext _applicationDbContext;

        public ProductsController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpGet]
        [Route("getall")]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _applicationDbContext.products.ToListAsync();
        }

        [HttpPost]
        [Route("add")]
        public async Task AddProduct(Product entity)
        {
            await _applicationDbContext.products.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        [HttpGet]
        [Route("get")]
        public async Task<Product> Get(int id)
        {
            return await _applicationDbContext.products.Include(p => p.ProductDetails).Where(p => p.ID == id).FirstOrDefaultAsync();
        }

        [HttpPost]
        [Route("search")]
        public async Task<List<Product>> Search(string value)
        {
            var products = await _applicationDbContext.products.Where(p => p.Name.Contains(value)).ToListAsync();

            return products;
        }
    }
}