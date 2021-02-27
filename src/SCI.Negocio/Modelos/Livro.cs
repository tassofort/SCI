using System;
using System.Collections.Generic;
using System.Text;

namespace SCI.Negocio.Modelos
{
    public class Livro : DadosCadComum
    {
        public string Titulo { get; set; }
        public int CategId { get; set; }
        /* EF Relations */
        public Categ Categoria { get; set; }
        public decimal P_Venda { get; set; }
        public decimal P_Custo { get; set; }
        public decimal Base_Calc { get; set; }
        public string Formatado { get; set; }
        public int NPaginas { get; set; }
        public int Edicao { get; set; }
        public int Ano { get; set; }
        public decimal Peso { get; set; }
        public string Loc { get; set; }
        public string Resenha { get; set; }
        public string Capa { get; set; }
        public bool Promo { get; set; }
        public int Est_Min { get; set; }
        public int Est_Disp { get; set; }
        public int QtDoac { get; set; }
        public int QtDons { get; set; }
        public int QtVend { get; set; }
    }
}
