using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace migration_relacao_atual.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(100)] // Define o tamanho máximo do campo Nome como 100 caracteres
        public string Nome { get; set; }

        // Define a relação com a classe CarteiraMotorista
        [ForeignKey("Cnh")]
        public int CarteiraMotoristaId { get; set; }
        public CarteiraMotorista Cnh { get; set; }
    }
}
