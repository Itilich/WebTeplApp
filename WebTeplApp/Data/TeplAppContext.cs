using Microsoft.EntityFrameworkCore;

namespace WebTeplApp.Data
{
    public class TeplAppContext: DbContext
    {
        public DbSet<Variant> Variants { get; set; }

        public TeplAppContext(DbContextOptions<TeplAppContext> options): base(options) 
        { 
            
        }

    }
}
