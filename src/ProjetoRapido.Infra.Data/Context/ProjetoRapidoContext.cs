using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ProjetoRapido.Infra.Data.Entities;
using System.IO;

namespace ProjetoRapido.Infra.Data.Context
{
    public class ProjetoRapidoContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public ProjetoRapidoContext(DbContextOptions<ProjetoRapidoContext> options)
            : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"))
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Cliente>().ToTable("Cliente")
                .HasKey(e => e.ClienteID);
            builder.Entity<Cliente>().Property(c => c.Nome).HasMaxLength(80);
            builder.Entity<Cliente>().Property(c => c.SobreNome).HasMaxLength(100);

            builder.Entity<Endereco>().ToTable("Endereco");
            builder.Entity<Endereco>().HasKey(e => e.EnderecoID);
            builder.Entity<Endereco>().Property(e => e.Logradouro).HasMaxLength(150);
            builder.Entity<Endereco>().Property(e => e.Numero).HasMaxLength(10);
            builder.Entity<Endereco>().Property(e => e.Cep).HasMaxLength(8);
            builder.Entity<Endereco>().Property(e => e.Bairro).HasMaxLength(100);
            builder.Entity<Endereco>().Property(e => e.Cidade).HasMaxLength(100);
            builder.Entity<Endereco>().Property(e => e.Estado).HasMaxLength(50);

        }
    }
}
