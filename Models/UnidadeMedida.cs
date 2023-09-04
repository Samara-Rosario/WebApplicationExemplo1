namespace WebApplicationExemplo1.Models {
    public class UnidadeMedida {
        public int Id { get; set; }
        public string NomeExtenso { get; set; }
        public string Sigla { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
