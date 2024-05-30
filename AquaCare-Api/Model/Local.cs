using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaCare_Api.Model
{
    [Table("Locais")]
    public class Local
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoLocal { get; set; }

        [ForeignKey("Cidade")]
        public int CodigoCidade { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }
        public string Descricao { get; set; }

        [MaxLength(50)]
        public string Latitude { get; set; }

        [MaxLength(50)]
        public string Longitude { get; set; }

        public Cidade Cidade { get; set; }
    }
}
