using Microsoft.EntityFrameworkCore;
using TrabajoFinalProem_GalanFlorencia.Models;//vincula con mis modelos creados

namespace TrabajoFinalProem_GalanFlorencia.datos
{
    public class ApplicationDbContext : DbContext

    {
        //llamo a la BD que esta en appseting
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // modelos que uso , despues se migraran a la BD
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<Pagos> Pagos { get; set; }

    }
}
