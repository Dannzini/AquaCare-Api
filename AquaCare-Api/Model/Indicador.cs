using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaCare_Api.Model
{
    [Table("AQUACARE_INDICADOR")]
    public class Indicador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CODIGO_INDICADOR")]
        public int CodigoIndicador { get; set; }

        [Required]
        [ForeignKey("Local")]
        [Column("CODIGO_LOCAL")]
        public int CodigoLocal { get; set; }

        [Required]
        [Column("DATA_HORA_MEDICAO")]
        public DateTime DataHoraMedicao { get; set; }

        [Required]
        [Column("NIVEL_COLIFORMES")]
        public int NivelColiformes { get; set; }

        [Required]
        [Column("NIVEL_PH")]
        public decimal NivelPH { get; set; }

        [Required]
        [Column("NIVEL_OXIGENIO_DISSOLVIDO")]
        public decimal NivelOxigenioDissolvido { get; set; }

        [Required]
        [Column("NIVEL_TURBIDEZ")]
        public decimal NivelTurbidez { get; set; }

        [Required]
        [Column("NIVEL_TEMPERATURA")]
        public decimal NivelTemperatura { get; set; }

        [ForeignKey("CodigoLocal")]
        public Local Local { get; set; }
    }
}
