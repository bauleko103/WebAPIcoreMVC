using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HocWebAPICore.Data
{
    public class HocWebAPICoreContext : DbContext
    {
        public HocWebAPICoreContext (DbContextOptions<HocWebAPICoreContext> options)
            : base(options)
        {
        }
        #region
        public DbSet<HocWebAPICore.Data.Book> Book { get; set; } = default!;
        public DbSet<HocWebAPICore.Data.HangHoa> HangHoas{ get; set; } = default!;
        public DbSet<HocWebAPICore.Data.Loai> Loais { get; set; } = default!;
        #endregion
    }
}
