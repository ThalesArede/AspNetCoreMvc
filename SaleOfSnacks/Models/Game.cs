namespace SaleOfSnacks.Models
{
    public class Game // Entidade Game
    {
        public int GameId { get; set; } // Lanche ID
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public decimal Preco { get; set; }

        public string ImagemUrl { get; set; }

        public string ImagemThumbnailUrl { get; set; }

        public bool GameEfavorito { get; set; } // Is lanche preferido
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; } 
        public virtual Categoria Categoria { get; set; } // Propriedades dos Games


    }
}
