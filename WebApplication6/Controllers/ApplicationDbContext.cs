using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models

{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext
            (DbContextOptions<ApplicationDbContext> options) :
            base(options)
        { }
       public DbSet<Location>Locations { get; set; }
       public DbSet<Customer>Customers { get; set; }



    }
}
