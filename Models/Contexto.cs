using Microsoft.EntityFrameworkCore;

namespace ServerCRUDAPI.Models{

    public class Contexto : DbContext
    {
        public required DbSet<Pessoa> Pessoas {get; set;}

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {
            
        }
    }
}

