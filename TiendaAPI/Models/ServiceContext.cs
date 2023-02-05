using Microsoft.EntityFrameworkCore;

namespace TiendaAPI.Models
{
    public class ServiceContext : DbContext
    {
        public ServiceContext()
        {

        }
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options)
        {

        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<User> User { get; set; }

    }
}
