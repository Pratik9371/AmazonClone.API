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
        public async Task<List<Cart>> Get(int userId)
        {
            return await _applicationDbContext.cart.Where(c => c.UserID == userId).Include(c => c.Product).ToListAsync();
        }

        [HttpDelete]
        [Route("remove")]
        public async Task Remove(int id)
        {
            var dbEntity = await _applicationDbContext.cart.FirstOrDefaultAsync(c => c.ID == id);
            _applicationDbContext.cart.Remove(dbEntity);
            await _applicationDbContext.SaveChangesAsync();
        }

        [HttpPut]
        [Route("update")]
        public async Task Update(Cart entity)
        {
            var dbEntity = await _applicationDbContext.cart.FirstOrDefaultAsync(c => c.ID == entity.ID);

            dbEntity.Quantity = entity.Quantity;

            await _applicationDbContext.SaveChangesAsync();
        }
    }
}