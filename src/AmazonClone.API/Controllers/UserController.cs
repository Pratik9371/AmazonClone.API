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
    public class UserController : Controller
    {
        ApplicationDbContext _applicationDbContext;
        public UserController(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("createuser")]
        public async Task Create(User entity)
        {
            //entity.Password = EncDec.Encrypt(entity.Password);
            await _applicationDbContext.User.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();
        }

        [HttpGet]
        [Route("getuser")]
        public async Task<User> Get(long Id)
        {
           return await _applicationDbContext.User.FirstOrDefaultAsync(u => u.ID == Id);
        }

        [HttpPost]
        [Route("login")]
        public async Task<User> login(User entity)
        {
          var user = await _applicationDbContext.User.Where(u => u.Email == entity.Email && u.Password == entity.Password).FirstOrDefaultAsync();

          return user;
        }
    }
}