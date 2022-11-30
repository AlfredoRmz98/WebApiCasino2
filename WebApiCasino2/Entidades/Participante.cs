using System.ComponentModel.DataAnnotations;

namespace WebApiCasino2.Entidades
{
    public class Participante
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="el campo {0} es requerido")]
        [StringLength(maximumLength: 50, ErrorMessage = "El campo {0} solo puede tener hasta 50 caracteres")]
        public string Nombre { get; set; }

        public List<ParticipanteRifa> ParticipanteRifa { get; set; }
    }
}
