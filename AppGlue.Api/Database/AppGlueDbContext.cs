using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGlue.Api.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace AppGlue.Api.Database
{
    public class AppGlueDbContext : DbContext
    {
        public AppGlueDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Computer> Computers { get; set; }
    }
}
