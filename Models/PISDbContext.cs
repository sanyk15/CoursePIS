using System.Data.Entity;

namespace Models
{
    public class PISDbContext : DbContext
    {
        public PISDbContext() : base("PISDatabase")
        {
            //настройки конфигурации для entity
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ClientContract> ClientContracts { set; get; }
        public DbSet<AgentContract> AgentContracts { set; get; }
        public DbSet<Tour> Tours { set; get; }
        public DbSet<Statement> Statements { set; get; }
        public DbSet<TableStatement> TableStatements { set; get; }
    }
}