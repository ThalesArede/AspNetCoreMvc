using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleOfSnacks.Models
{

    [Table("Games")]

    public class Game // Entidade Game
    {
        [Key]

        public int GameId { get; set; } // Lanche ID
        
        [Required(ErrorMessage = "O nome do game deve ser informado")]
        [Display(Name = "Nome do Game")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} ")]       
        public string Nome { get; set; }
       
        [Required(ErrorMessage = "O nome do game deve ser informado")]
        [Display(Name = "Nome do Game")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string DescricaoCurta { get; set; }
       
        [Required(ErrorMessage = "O nome do game deve ser informado")]
        [Display(Name = "Nome do Game")]
        [MinLength(20, ErrorMessage = "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(200, ErrorMessage = "Descrição pode exceder {1} caracteres")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage = "Informe o preço do game")]
        [Display(Name ="Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999.99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }

        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }

        [Display(Name = "Preferido")]
        public bool IsGamePreferido { get; set; } // Is lanche preferido

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; } 
        public virtual Categoria Categoria { get; set; } // Propriedades dos Games

    }
}