using VoeAirlines.Context;
using VoeAirlines.Entities;
using VoeAirlines.EntityConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ManutencaoConfigurations : IEntityTypeConfiguration<Manutencao>
{
    public void Configure(EntityTypeBuilder<Manutencao> builder)
    {
        //Tabela?
        builder.ToTable("Manutencao");

        //Chave primária
        builder.HasKey(m=>m.Id);

        //Propriedade DataHora
        builder.Property(m=>m.DataHora)
             .IsRequired();
        //Propriedade Tipo
        builder.Property(m=>m.Tipo)
              .IsRequired();
    } 
}