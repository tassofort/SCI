using SCI.Negocio.Modelos.NovosTipos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCI.App.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        [DisplayName("Código")]
        public int Id { get; set; }

        [DisplayName("Habilitada")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Status { get; set; }

        [DisplayName("Marca")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public bool Marca { get; set; }
        
        [DisplayName("Inclusão")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Data_Inc { get; set; }
        
        [DisplayName("Alteração")]
        public DateTime? Data_Alt { get; set; }
        
        [DisplayName("Habilitação")]
        public DateTime? Data_Hab { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(25, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(25, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public GrupoCategoria Grupo { get; set; }
    }
}
