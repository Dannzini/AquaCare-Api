namespace AquaCare_Api.Model
{
    public class Local
    {
        public int CodigoLocal { get; set; }
        public int CodigoCidade { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public Cidade Cidade { get; set; }
    }
}
