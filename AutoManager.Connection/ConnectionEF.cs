using Microsoft.EntityFrameworkCore;

namespace AutoManager.Connection
{
    public class ConnectionEF : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConnectionEF).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMongoDB
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
        }

        public ConnectionEF(DbContextOptions options) : base(options)
        {

        }

        //public static ConnectionEF Create(IMongoDatabase database) => new(new DbContextOptionsBuilder<ConnectionEF>().UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName).Options);
    }
}
