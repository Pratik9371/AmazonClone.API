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
    public class CartController : Controller
    {
        ApplicationDbContext _applicationDbContext;

        public CartController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }   

        [HttpPost]
        [Route("add")]
        public async Task Add(Cart entity)
        {
            await _applicationDbContext.cart.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        [HttpGet]
        [Route("get")]
        public async Task<Cart> Get(int userId)
        {
            return await _applicationDbContext.cart.Where(c=>c.UserID == userId).Include(c=>c.Product).FirstOrDefaultAsync();
        }
    }
}