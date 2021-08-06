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

        public DbSet<User> users { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Cart> cart { get; set; }
        public DbSet<ProductDetails> productdetails { get; set; }
    }
}
