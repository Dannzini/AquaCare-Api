using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaCare_Api.Model
{
    [Table("AQUACARE_USUARIO")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO_USUARIO")]
        public int CodigoUsuario { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("NOME")]
        public string Nome { get; set; }

        [Required]
        [MaxLength(100)]
        [EmailAddress]
        [Column("EMAIL")]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("SENHA")]
        public string Senha { get; set; }
    }
}
