namespace WebApplicationExemplo1.Models {
    public class Produto {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Estoque { get; set; }
        public string PrecoUnitario { get; set;}
        public UnidadeMedida unidadeMedida { get; set; }

    }
}
