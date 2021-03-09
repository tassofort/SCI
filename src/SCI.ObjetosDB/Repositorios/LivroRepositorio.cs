using Microsoft.EntityFrameworkCore;
using SCI.Negocio.Interfaces;
using SCI.Negocio.Modelos;
using SCI.ObjetosDB.Conexao;
using System;
using System.Collections.Generic;
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
    }


}
