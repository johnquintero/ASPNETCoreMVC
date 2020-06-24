using Microsoft.EntityFrameworkCore;

namespace AlphaWebApp.Data
{
    public class TiendaLibrosContext : DbContext
    {
        public TiendaLibrosContext(DbContextOptions<TiendaLibrosContext> options) : base(options)
        {

        }

        public DbSet<Libros> Libros {get; set;}

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseMySql("Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;");
        //     base.OnConfiguring(optionsBuilder);
        // }
    }
}