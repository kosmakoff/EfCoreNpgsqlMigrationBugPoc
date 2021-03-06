// <auto-generated />
using EfCoreNpgsqlMigrationBugPoc;
using EfCoreNpgsqlMigrationBugPoc.First;
using EfCoreNpgsqlMigrationBugPoc.Second;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EfCoreNpgsqlMigrationBugPoc.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasPostgresEnum(null, "first_some_state", new[] { "one", "two" })
                .HasPostgresEnum(null, "second_some_state", new[] { "three", "four", "five" })
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EfCoreNpgsqlMigrationBugPoc.EntityOne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<SomeState>("State")
                        .HasColumnType("first_some_state");

                    b.HasKey("Id");

                    b.ToTable("Ones");
                });

            modelBuilder.Entity("EfCoreNpgsqlMigrationBugPoc.EntityTwo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<SomeState>("State")
                        .HasColumnType("second_some_state");

                    b.HasKey("Id");

                    b.ToTable("Twos");
                });
#pragma warning restore 612, 618
        }
    }
}
