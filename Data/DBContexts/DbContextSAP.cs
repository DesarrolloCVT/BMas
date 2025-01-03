using Microsoft.EntityFrameworkCore;
using NuevoBMas.Models;

namespace Proyecto.Data.DbContexts
{
    public class SapDbContext : DbContext
    {
        public SapDbContext(DbContextOptions<SapDbContext> options)
        : base(options) { }

      
    }
}
