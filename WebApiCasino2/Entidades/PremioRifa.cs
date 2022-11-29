namespace WebApiCasino2.Entidades
{
    public class PremioRifa
    {
        public int RifaId { get; set; }
        public string PremioNombre { get; set; }
        public Rifa Rifa { get; set; }
        public Premio Premio { get; set; }
    }
}
