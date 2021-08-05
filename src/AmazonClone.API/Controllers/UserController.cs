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

        [HttpPost]
        [Route("createuser")]
        public async Task<long> Create(User entity)
        {
            //entity.Password = EncDec.Encrypt(entity.Password);
            await _applicationDbContext.users.AddAsync(entity);
            await _applicationDbContext.SaveChangesAsync();

            return entity.ID;
        }

        [HttpGet]
        [Route("getuser")]
        public async Task<User> Get(int Id)
        {
           return await _applicationDbContext.users.FirstOrDefaultAsync(u => u.ID == Id);
        }

        [HttpPost]
        [Route("login")]
        public async Task<User> login(User entity)
        {
          var user = await _applicationDbContext.users.Where(u => u.Email == entity.Email && u.Password == entity.Password).FirstOrDefaultAsync();

          return user;
        }
    }
}