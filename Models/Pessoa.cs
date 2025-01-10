namespace ServerCRUDAPI.Models{

    public class Pessoa
    {
        public int PessoaId {get ; set;}
        public required string Nome {get ; set;}
        public required string Sobrenome {get ; set;}
        public required int Idade {get ; set;}
        public required string Profissao {get ; set;}
    }
}

