using SCI.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SCI.Negocio.Modelos;
using SCI.ObjetosDB.Conexao;
using System.Linq;

namespace SCI.ObjetosDB.Repositorios
{
    public abstract class Repositorio<TEntity> : IRepositorio<TEntity> where TEntity : DadosCadComum, new()
    {
        protected readonly ConexaoDb Db;
        protected readonly DbSet<TEntity> DbSet;

        // await = esperar o resultado que vem do banco ...

        protected Repositorio(ConexaoDb db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();

        }

        public virtual async Task Remover(int id)
        {
            DbSet.Remove(new TEntity { Id = id });
            await SaveChanges();
        }

        public virtual async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();                
        }

        public virtual async Task<TEntity> ObterPorId(int id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            //? = se existir faz dipose()
            Db?.Dispose();
        }

    }
}
