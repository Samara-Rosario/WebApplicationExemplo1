namespace WebApplicationExemplo1.Models {
    public class Aluno {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Responsavel { get; set; }
        public Turma turma { get; set; }

    }
}
