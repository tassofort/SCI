using Microsoft.EntityFrameworkCore;
using SCI.Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCI.ObjetosDB.Conexao
{
    public class ConexaoDb : DbContext
    {
        public ConexaoDb(DbContextOptions<ConexaoDb> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ConexaoDb).Assembly);
            MapeaarPropriedadeEsquecidas(modelBuilder);
        }
        //Configurando aplicação pra salvar no banco o tipo string com no maximo 100, caso não seja referenciado,
        //evitando um nvarchar/maxvarchar
        private void MapeaarPropriedadeEsquecidas(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p => p.ClrType == typeof(string));

                foreach (var property in properties)
                {
                    if (string.IsNullOrEmpty(property.GetColumnType())
                        && !property.GetMaxLength().HasValue)
                    {
                        property.SetColumnType("VARCHAR(100)");
                    }

                }
            }
        }
    }
}
