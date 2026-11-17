using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using buoi6.Models;

namespace buoi6.Data
{
    public class buoi6Context : DbContext
    {
        public buoi6Context (DbContextOptions<buoi6Context> options)
            : base(options)
        {
        }

        public DbSet<buoi6.Models.Product> Product { get; set; } = default!;
        public DbSet<buoi6.Models.Genre> Genre { get; set; } = default!;
        public DbSet<buoi6.Models.Movie> Movie { get; set; } = default!;
    }
}
