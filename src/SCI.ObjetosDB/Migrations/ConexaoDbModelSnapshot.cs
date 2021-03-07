﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SCI.ObjetosDB.Conexao;

namespace SCI.ObjetosDB.Migrations
{
    [DbContext(typeof(ConexaoDb))]
    partial class ConexaoDbModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SCI.Negocio.Modelos.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Data_Alt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Data_Hab")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Inc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Grupo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(25)");

                    b.Property<bool>("Marca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(25)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValueSql("1");

                    b.HasKey("Id");

                    b.ToTable("Categ");
                });

            modelBuilder.Entity("SCI.Negocio.Modelos.Livro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<short?>("Ano")
                        .HasColumnType("SMALLINT");

                    b.Property<decimal?>("Base_Calc")
                        .HasColumnType("DECIMAL(16,2)");

                    b.Property<string>("Capa")
                        .HasColumnType("VARCHAR(100)");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Data_Alt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Data_Hab")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Data_Inc")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<short?>("Edicao")
                        .HasColumnType("SMALLINT");

                    b.Property<int?>("Est_Disp")
                        .HasColumnType("INT");

                    b.Property<int?>("Est_Min")
                        .HasColumnType("INT");

                    b.Property<string>("Formatado")
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("VARCHAR(13)");

                    b.Property<string>("Loc")
                        .HasColumnType("VARCHAR(10)");

                    b.Property<bool>("Marca")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValueSql("1");

                    b.Property<short?>("NPaginas")
                        .HasColumnType("SMALLINT");

                    b.Property<decimal?>("P_Custo")
                        .HasColumnType("DECIMAL(16,2)");

                    b.Property<decimal?>("P_Venda")
                        .HasColumnType("DECIMAL(16,2)");

                    b.Property<decimal?>("Peso")
                        .HasColumnType("DECIMAL(16,2)");

                    b.Property<bool>("Promo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValueSql("0");

                    b.Property<int?>("QtCons")
                        .HasColumnType("INT");

                    b.Property<int?>("QtDoac")
                        .HasColumnType("INT");

                    b.Property<int?>("QtVend")
                        .HasColumnType("INT");

                    b.Property<string>("Resenha")
                        .HasColumnType("VARCHAR(1000)");

                    b.Property<bool>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("BIT")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("Titulo")
                        .HasName("titulo_Livros");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("SCI.Negocio.Modelos.Livro", b =>
                {
                    b.HasOne("SCI.Negocio.Modelos.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
