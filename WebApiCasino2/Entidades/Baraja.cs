using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCasino2.Entidades
{
    public class Baraja
    {
        [NotMapped]
        public int Nombre { get; set; }
        public int Id { get; set; }
        public string UsuarioId { get; set; }
        public IdentityUser Usuario { get; set; }

        public List<Participante> Participante { get; set; }
        public List<ParticipanteRifa> ParticipanteRifa { get; set; }
        public List<Rifa> Rifa { get; set; }
        public List<Premio> Premio { get; set; }
    }
}
