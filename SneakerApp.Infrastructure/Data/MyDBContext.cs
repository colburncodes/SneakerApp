 using System.Data;
 using SneakerApp.Infrastructure.Entity;
using Microsoft.EntityFrameworkCore;
 
 namespace SneakerApp.Infrastructure;
 public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
    }