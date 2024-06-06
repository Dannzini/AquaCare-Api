using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaCare_Api.Model
{
    [Table("AQUACARE_LOCAL")]
    public class Local
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO_LOCAL")]
        public int CodigoLocal { get; set; }

        [Required]
        [ForeignKey("Cidade")]
        [Column("CODIGO_CIDADE")]
        public int CodigoCidade { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("NOME")]
        public string Nome { get; set; }

        [MaxLength(250)]
        [Column("DESCRICAO")]
        public string Descricao { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("LATITUDE")]
        public string Latitude { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("LONGITUDE")]
        public string Longitude { get; set; }
    }
}
