namespace WebApiCasino2.Entidades
{
    public class RifaPremio
    {
        
        public int RifaId { get; set; }
        public int PremioId { get; set; }
        public Rifa Rifa { get; set; }
        public Premio Premio { get; set; }
        public string RifaNombre { get;  set; }
    }
}
