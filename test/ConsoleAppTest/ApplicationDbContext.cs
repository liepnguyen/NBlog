using Planru.Auth.Core.Persistence.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleAppTest
{
    public class ApplicationDbContext : AuthDbContext
    {
        public ApplicationDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        public ApplicationDbContext() : base() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(local);Database=TestDB;Trusted_Connection=True;");
        }
    }
}
