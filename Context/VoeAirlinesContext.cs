using Microsoft.EntityFrameworkCore;
using VoeAirlines.Entities;
using VoeAirlines.EntityConfigurations; 

namespace VoeAirlines.Context
{
    public class VoeAirlinesContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public VoeAirlinesContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

    

        public DbSet<Aeronave> Aeronaves =>Set<Aeronave>();
        public DbSet<Piloto> Pilotos =>Set<Piloto>();
        public DbSet<Voo> Voos =>Set<Voo>();
        public DbSet<Cancelamento> Cancelamentos =>Set<Cancelamento>();
        public DbSet<Manutencao> Manutencaos =>Set<Manutencao>();

        //Encapsulamento
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("VoeAirline"));
        }
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AeronaveConfigurations());
            modelBuilder.ApplyConfiguration(new PilotoConfiguration());
            modelBuilder.ApplyConfiguration(new VooConfigurations());
            modelBuilder.ApplyConfiguration(new CancelamentoConfigurations());
            modelBuilder.ApplyConfiguration(new ManutencaoConfigurations());
        }
    }
}
