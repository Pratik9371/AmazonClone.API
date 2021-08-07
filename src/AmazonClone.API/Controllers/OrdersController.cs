using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonClone.DbContexts;
using AmazonClone.Models;
using Microsoft.AspNetCore.Mvc;

namespace AmazonClone.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : Controller
    {
        ApplicationDbContext _applicationDbContext;

        public OrdersController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        [HttpPost]
        [Route("add")]
        public async Task Add(Orders entity)
        {
            var result = await _applicationDbContext.orders.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}