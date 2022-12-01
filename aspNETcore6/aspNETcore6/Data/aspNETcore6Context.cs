using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aspNETcore6.Data
{
    public class aspNETcore6Context : DbContext
    {
        public aspNETcore6Context (DbContextOptions<aspNETcore6Context> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; } = default!;
        public DbSet<Standard> Standards { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Boss> Boss { get; set; }
    }
}
