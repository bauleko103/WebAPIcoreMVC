using Microsoft.EntityFrameworkCore;

namespace WebApp.Data
{
    public class MyDbContext: DbContext
    {
         public MyDbContext(DbContextOptions options) : base(options)
        {

        }
        #region DBset
        public DbSet<HangHoa> HangHoa { get; set; }
        public DbSet<Loai> Loais { get; set; }
        #endregion
    }
}
