using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433;Database=ReszonDB;User ID=sa;Password=1q2w3e4r@#$;");
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning));
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }
    }




    // comando que gera a migração
    // dotnet ef migrations add PrimeiraMigracao -p CursoEFCore

    // comando que gera o script de banco
    // dotnet ef migrations script -p CursoEFCore -o .\CursoEFCore\Data\PrimeiraMigracao.SQL

    // comando que gera as tabelas a partir do script
    // dotnet ef database update -p CursoEFCore -v

    // comando para executar a geracao de script idempotente, onde verifica se já existe a tabela no banco
    // dotnet ef migrations script -p CursoEFCore -o .\CursoEFCore\Data\Idempotente.SQL -i

    // gera as tabelas baseado nas migrações
    // Update-Database MigrationReszon
}
