using Microsoft.EntityFrameworkCore;
using SCI.Negocio.Interfaces;
using SCI.Negocio.Modelos;
using SCI.ObjetosDB.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCI.ObjetosDB.Repositorios
{
    public class LivroRepositorio : Repositorio<Livro>, ILivroRepositorio
    {
        public LivroRepositorio(ConexaoDb dbx) : base(dbx) {}

        public async Task<Livro> ObterLivroCategoria(int id)
        {
            return await Db.Livros.AsNoTracking().Include(c => c.Categoria).FirstOrDefaultAsync(l => l.Id == id);
        }

        public async Task<IEnumerable<Livro>> ObterLivrosCategorias()
        {
            return await Db.Livros.AsNoTracking().Include(c => c.Categoria).OrderBy(l => l.Titulo).ToListAsync();
        }

        public async Task<IEnumerable<Livro>> ObterLivrosPorCategoria(int categoriaId)
        {
            return await Buscar(l => l.CategoriaId == categoriaId);
        }
    }


}
