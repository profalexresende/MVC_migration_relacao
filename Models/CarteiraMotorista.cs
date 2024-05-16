using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace migration_relacao_atual.Models
{
    public class CarteiraMotorista
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarteiraMotoristaId { get; set; }

        [Required]
        [Column(TypeName = "DATE")] // Oracle type for DATE
        public DateTime DataValidade { get; set; }
    }
}
