using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UsersInDbWebEf.Models;

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<UsersInDbWebEf.Models.Customer> Customer { get; set; } = default!;

        public DbSet<UsersInDbWebEf.Models.Address> Address { get; set; } = default!;
    }
