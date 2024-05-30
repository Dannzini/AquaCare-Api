namespace AquaCare_Api.Model
{
    public class Indicador
    {
        public int CodigoIndicador { get; set; }
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
