using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaCare_Api.Model
{
    [Table("AQUACARE_CIDADE")]
    public class Cidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO_CIDADE")]
        public int CodigoCidade { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("NOME")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("ESTADO")]
        public string Estado { get; set; }
    }
}
