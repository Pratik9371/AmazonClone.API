using AmazonClone.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace AmazonClone.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
    }
}
