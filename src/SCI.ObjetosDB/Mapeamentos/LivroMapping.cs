using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SCI.Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.ObjetosDB.Mapeamentos
{
    public class LivroMapping : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livros");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Status).HasColumnType("BIT").HasDefaultValueSql("1").IsRequired();
            builder.Property(c => c.Marca).HasColumnType("BIT").HasDefaultValueSql("1").IsRequired();
            builder.Property(c => c.Data_Inc).HasDefaultValueSql("GETDATE()").ValueGeneratedOnAdd().IsRequired();

            builder.Property(c => c.ISBN).HasColumnType("VARCHAR(13)").IsRequired();
            builder.Property(c => c.Titulo).HasColumnType("VARCHAR(50)").IsRequired();
            builder.Property(c => c.P_Venda).HasColumnType("DECIMAL(16,2)");
            builder.Property(c => c.P_Custo).HasColumnType("DECIMAL(16,2)");
            builder.Property(c => c.Base_Calc).HasColumnType("DECIMAL(16,2)");
            builder.Property(c => c.Formatado).HasColumnType("VARCHAR(15)");
            builder.Property(c => c.NPaginas).HasColumnType("SMALLINT");
            builder.Property(c => c.Edicao).HasColumnType("SMALLINT");
            builder.Property(c => c.Ano).HasColumnType("SMALLINT");
            builder.Property(c => c.Peso).HasColumnType("DECIMAL(16,2)");
            builder.Property(c => c.Loc).HasColumnType("VARCHAR(10)");
            builder.Property(c => c.Resenha).HasColumnType("VARCHAR(1000)");
            builder.Property(c => c.Capa).HasColumnType("VARCHAR(100)");
            builder.Property(c => c.Promo).HasColumnType("BIT").HasDefaultValueSql("0").IsRequired();
            builder.Property(c => c.Est_Min).HasColumnType("INT");
            builder.Property(c => c.Est_Disp).HasColumnType("INT");
            builder.Property(c => c.QtDoac).HasColumnType("INT");
            builder.Property(c => c.QtCons).HasColumnType("INT");
            builder.Property(c => c.QtVend).HasColumnType("INT");

            builder.HasOne(c => c.Categoria);
            
            builder.HasIndex(c => c.Titulo).HasName("titulo_Livros");
        }
    }
}
