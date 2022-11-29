using System.ComponentModel.DataAnnotations;

namespace WebApiCasino2.Entidades
{
    public class Rifa
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "El campo {0} solo puede tener hasta 100 caracteres")]
        public string Nombre { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public List<ParticipanteRifa> ParticipanteRifa { get; set; }
        public List<Baraja> Baraja { get; set; }
    }
}
