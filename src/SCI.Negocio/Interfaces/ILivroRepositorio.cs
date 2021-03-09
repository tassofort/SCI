using SCI.Negocio.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SCI.Negocio.Interfaces
{
    public interface ILivroRepositorio : IRepositorio<Livro>
    {
        Task<Livro> ObterLivroCategoria(int id);
    }
}
