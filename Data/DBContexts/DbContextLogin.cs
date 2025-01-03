using Microsoft.EntityFrameworkCore;

namespace Proyecto.Data.DbContexts
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options)
            : base(options) { }

        
    }
}
