﻿namespace WantedClothingWebsite.Data
{
    using Microsoft.EntityFrameworkCore;
    using WantedClothingWebsite.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
