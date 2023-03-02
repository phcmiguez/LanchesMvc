using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMvc.Models
{
    public class Lanche
    {
        [Display(Name = "Cód.")]
        public int LancheId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string Nome { get; set; }

        [Display(Name = "Descrição Curta")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string DescricaoCurta { get; set; }

        [Display(Name = "Descrição Longa")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(1000, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "O preço deve estar entre R$1 e R$999,99")]
        public decimal Preco { get; set; }

        [Display(Name = "Imagem")]
        [MaxLength(255, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Miniatura")]
        [MaxLength(255, ErrorMessage = "A descrição deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido?")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque?")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public bool EmEstoque { get; set; }


        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
