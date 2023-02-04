using Microsoft.EntityFrameworkCore;

namespace Todo_App_.Net_Core_6.DB
{
    public class DbContextTodo : DbContext
    {
        private readonly IConfiguration _conf;
        // definition des tables de la base de données

        public DbContextTodo(DbContextOptions options, IConfiguration conf) : base(options)
        {
            _conf = conf;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_conf.GetConnectionString("TodoDb"));
        }
    }
}
