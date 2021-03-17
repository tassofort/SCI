using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SCI.App.ViewModels
{
    public class LivroViewModel
    {
        [Key]
        [DisplayName("Código")]
        public int Id { get; set; }

        [DisplayName("Habilitar?")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Status { get; set; }

        [DisplayName("Marcar?")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Marca { get; set; }

        [DisplayName("Inclusão")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Data_Inc { get; set; }

        [DisplayName("Alteração")]
        public DateTime? Data_Alt { get; set; }

        [DisplayName("Habilitação")]
        public DateTime? Data_Hab { get; set; }
        
        [DisplayName("ISBN")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string ISBN { get; set; }

        [DisplayName("Título do livro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 5)]
        public string Titulo { get; set; }

        [DisplayName("Categoria")]
        public int CategoriaId { get; set; }

        [DisplayName("Preço de venda")]
        public decimal? P_Venda { get; set; }

        [DisplayName("Preço de custo")]
        public decimal? P_Custo { get; set; }

        [DisplayName("Base de cálculo do ICMS")]
        public decimal? Base_Calc { get; set; }

        [DisplayName("Formato")]
        public string? Formatado { get; set; }

        [DisplayName("Nº de páginas")]
        public int? NPaginas { get; set; }

        [DisplayName("Edição")]
        public int? Edicao { get; set; }

        [DisplayName("Ano")]
        public int? Ano { get; set; }

        [DisplayName("Peso")]
        public decimal? Peso { get; set; }

        [DisplayName("Localização")]
        public string? Loc { get; set; }

        [DisplayName("Resenha")]
        public string? Resenha { get; set; }

        [DisplayName("Inserir imagem da capa")]
        public IFormFile ImagemUpload { get; set; }

        [DisplayName("Capa")]
        public string Capa { get; set; }

        [DisplayName("Promoção")]
        public bool Promo { get; set; }

        [DisplayName("Estoque mínimo")]
        public int? Est_Min { get; set; }

        [DisplayName("Qtde Disponível")]
        public int? Est_Disp { get; set; }

        [DisplayName("Doações")]
        public int? QtDoac { get; set; }

        [DisplayName("Consignaçãoes")]
        public int? QtCons { get; set; }

        [DisplayName("Qtde Vendida")]
        public int? QtVend { get; set; }

        public CategoriaViewModel Categoria { get; set; }

        public IEnumerable<CategoriaViewModel> Categorias { get; set; }
    }
}
