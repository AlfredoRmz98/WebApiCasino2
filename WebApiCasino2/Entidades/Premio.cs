using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApiCasino2.Entidades
{
    public class Premio
    {
        [Key]
        [Required]
        [StringLength(maximumLength:50, ErrorMessage = "El campo {0} solo puede tener hasta 50 caracteres")]
        public int Nombre { get; set; }
       public int RifaId { get; set; }
        public string UsuarioId { get; set; }
        public IdentityUser Usuario { get; set; }

        public List<Rifa> Rifa { get; set; } 
        public List<Participante> Participante { get; set; }
    }
}
