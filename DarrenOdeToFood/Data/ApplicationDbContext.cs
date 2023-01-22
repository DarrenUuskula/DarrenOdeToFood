using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using DarrenOdeToFood.Models;

namespace DarrenOdeToFood.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                        : base(options)
        {
        }
        public DbSet<DarrenOdeToFood.Models.RestaurantReview> RestaurantReview { get; set; }
    }
}
