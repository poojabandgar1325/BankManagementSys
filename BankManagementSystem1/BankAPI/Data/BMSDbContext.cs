using BankAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Data
{
    public class BMSDbContext : DbContext
    {
        public BMSDbContext(DbContextOptions<BMSDbContext> options) : base(options)
        {

        }

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<LoanDetail> LoanDetails { get; set; }
    
    }
}
