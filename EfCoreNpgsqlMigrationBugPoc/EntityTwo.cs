using EfCoreNpgsqlMigrationBugPoc.Second;

namespace EfCoreNpgsqlMigrationBugPoc
{
    public class EntityTwo
    {
        public int Id { get; set; }

        public SomeState State { get; set; }
    }
}