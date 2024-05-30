using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AquaCare_Api.Model
{
    [Table("Indicadores")]
    public class Indicador
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoIndicador { get; set; }
        
        [ForeignKey("Local")]
        public int CodigoLocal { get; set; }
        public DateTime DataHoraMedicao { get; set; }
        public int NivelColiformes { get; set; }
        public decimal NivelPH { get; set; }
        public decimal NivelOxigenioDissolvido { get; set; }
        public decimal NivelTurbidez { get; set; }
        public decimal NivelTemperatura { get; set; }

        public Local Local { get; set; }
    }
}
