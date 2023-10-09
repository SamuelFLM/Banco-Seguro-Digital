using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Persistence
{
    public class BankContext : DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Client>(e =>
            {
                e.HasKey(c => c.Id);

                
            });
        }

    }
}