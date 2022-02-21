using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaleOfSnacks.Models
{

    [Table("Categorias")]

    public class Categoria // Entidade categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100,ErrorMessage ="O tamanho máximo é de 100 caracteres")]
        [Required(ErrorMessage ="Informe o nome da categoria")]
        [Display(Name ="Nome")]
        public string GategoriaNome { get; set; }
        [StringLength(200, ErrorMessage = "O tamanho máximo é de 200 caracteres")]
        [Required(ErrorMessage = "Informe a descrição da categoria")]
        [Display(Name = "Descrição")]

        public string Descrição { get; set; }

        public List<Game> Games { get; set; }   // Propriedades das categorias

    }
}