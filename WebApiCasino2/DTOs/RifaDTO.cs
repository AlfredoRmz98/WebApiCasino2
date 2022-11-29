namespace WebApiCasino2.DTOs
{
    public class RifaDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCreacion { get; set; }
        public List<PremioDTO> Premios { get; set; }
    }
}
