using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.Negocio.Modelos
{
    public abstract class DadosCadComum
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public bool Marca { get; set; }
        public DateTime Data_Inc { get; set; }
        public DateTime Data_Alt { get; set; }
        public DateTime Data_Hab { get; set; }
    }
}
