using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace EfCoreNpgsqlMigrationBugPoc
{
    public class AppDbContext : DbContext
    {
        static AppDbContext()
        {
            NpgsqlConnection.GlobalTypeMapper.MapEnum<First.SomeState>("first_some_state");
            NpgsqlConnection.GlobalTypeMapper.MapEnum<Second.SomeState>("second_some_state");
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
        }

        public DbSet<EntityOne> Ones { get; set; }

        public DbSet<EntityTwo> Twos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<First.SomeState>(name: "first_some_state");
            modelBuilder.HasPostgresEnum<Second.SomeState>(name: "second_some_state");
        }
    }
}