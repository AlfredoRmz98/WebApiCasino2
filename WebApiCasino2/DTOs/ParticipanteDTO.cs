using System.ComponentModel.DataAnnotations;
using WebApiCasino2.Validaciones;

namespace WebApiCasino2.DTOs
{
    public class ParticipanteDTO
    {
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 150, ErrorMessage = "El campo {0} solo puede tener hasta 150 caracteres")]
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
    }
}
