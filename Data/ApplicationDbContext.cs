using Microsoft.EntityFrameworkCore; 
using migration_relacao_atual.Models;

namespace migration_relacao_atual.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
       
        }

        // Define um DbSet para a entidade Cliente, representando uma tabela no banco de dados
        public DbSet<Cliente> Clientes { get; set; }

        // Define um DbSet para a entidade CarteiraMotorista, representando uma tabela no banco de dados
        public DbSet<CarteiraMotorista> CarteirasMotorista { get; set; }

        // Método chamado durante a inicialização do contexto do banco de dados para configurar o modelo
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // Chama a implementação da classe base (DbContext) do método OnModelCreating
            //Ajuda a manter a consistência e o comportamento esperado do contexto do banco de dados.
            base.OnModelCreating(modelBuilder); 
        }
    }
}
