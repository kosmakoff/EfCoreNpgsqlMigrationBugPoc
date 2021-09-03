using EfCoreNpgsqlMigrationBugPoc.First;

namespace EfCoreNpgsqlMigrationBugPoc
{
    public class EntityOne
    {
        public int Id { get; set; }

        public SomeState State { get; set; }
    }
}