using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCI.Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.ObjetosDB.Mapeamentos
{
    public class CategoriaMapping : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categ");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Status).HasColumnType("BIT").HasDefaultValueSql("1").IsRequired();
            builder.Property(c => c.Marca).HasColumnType("BIT").HasDefaultValueSql("1").IsRequired();
            builder.Property(c => c.Data_Inc).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd().IsRequired();

            builder.Property(c => c.Nome).HasColumnType("VARCHAR(25)").IsRequired();
            builder.Property(c => c.Grupo).HasConversion<string>().HasColumnType("VARCHAR(25)").IsRequired();

        }
    }
}
