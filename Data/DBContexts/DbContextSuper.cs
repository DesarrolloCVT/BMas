using Microsoft.EntityFrameworkCore;
using NuevoBMas.Models;

namespace Proyecto.Data.DbContexts
{
    public class WmsDbContext : DbContext
    {
        public WmsDbContext(DbContextOptions<WmsDbContext> options)
            : base(options) { }

        
    }
}
