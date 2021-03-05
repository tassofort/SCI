using SCI.Negocio.Modelos.NovosTipos;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.Negocio.Modelos
{
    public class Categoria : DadosCadComum
    {
        public string Nome { get; set; }
        public GrupoCategoria Grupo { get; set; }
    }
}
