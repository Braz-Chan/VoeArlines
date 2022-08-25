using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirlines.Entities;
namespace VoeAirlines.EntityConfigurations
{
    public class AeronaveConfigurations : IEntityTypeConfiguration<Aeronave>
    {
        //FLUENT INTERFACE
        public void Configure(EntityTypeBuilder<Aeronave> builder)
        {
            //Nomde da Tabela
            builder.ToTable("Aeronaves");

            //Cahve Primaria
            builder.HasKey(a=>a.Id);

            //Propriedade Fabricante
            builder.Property(a=>a.Fabricante)
                    .IsRequired()
                    .HasMaxLength(100);
            //Propriedade Modelo
            builder.Property(a=>a.Modelo)
                    .IsRequired()
                    .HasMaxLength(25);

            //Propriedade Codigo
            builder.Property(a=>a.Codigo)
                    .IsRequired()
                    .HasMaxLength(25);

            //Relacionamentos
            builder.HasMany(a=>a.Manutencoes)
                    .WithOne(m=>m.Aeronave)
                    .HasForeignKey(m=>m.AeronaveId);
        }
    }
}
