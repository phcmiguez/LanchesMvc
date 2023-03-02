using System.ComponentModel.DataAnnotations;

namespace LanchesMvc.Models
{
    public class Categoria
    {
        [Display(Name = "Cód.")]
        public int CategoriaId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string CategoriaNome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(600, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string Descricao { get; set; }


        public List<Lanche> Lanches { get; set; }
    }
}
