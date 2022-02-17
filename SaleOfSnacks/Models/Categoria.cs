namespace SaleOfSnacks.Models
{
    public class Categoria // Entidade categoria
    {
        public int CategoriaId { get; set; }
        public string GategoriaNome { get; set; }

        public string Descrição { get; set; }

        public List<Game> Games { get; set; }   // Propriedades das categorias

    }
}