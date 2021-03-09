using SCI.Negocio.Interfaces;
using SCI.Negocio.Modelos;
using SCI.ObjetosDB.Conexao;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.ObjetosDB.Repositorios
{
    public class CategoriaRepositorio : Repositorio<Categoria>, ICategoriaRepositorio
    {
        public CategoriaRepositorio(ConexaoDb db) : base(db) {}

    }
}
