using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServerCRUDAPI.Models
{
    public class Pessoa
    {
        [Key]
        public int PessoaId { get; set; }

        [Required, Column(TypeName = "VARCHAR(100)")]
        public string Nome { get; set; }

        [Required, Column(TypeName = "VARCHAR(100)")]
        public string Sobrenome { get; set; }

        [Required]
        public int Idade { get; set; }

        [Required, Column(TypeName = "VARCHAR(100)")]
        public string Profissao { get; set; }
    }
}
