using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_api_test.Models
{
    public class Entities : DbContext
    {
        public Entities(DbContextOptions<Entities> options) : base(options) { }

        public DbSet<Items> Items { get; set; }
    }
}
