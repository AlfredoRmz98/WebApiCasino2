using AutoMapper;
using WebApiCasino2.DTOs;
using WebApiCasino2.Entidades;

namespace WebApiCasino2.Utilidades
{
        public class AutoMapperProfiles : Profile
        {
            public AutoMapperProfiles()
            {
                //Establecemos el mappeo de EmpleadoDTO hacia la entidad Empleado
                CreateMap<ParticipanteDTO, Participante>();
                //Establecemos el mappeo de la entidad Empleado hacia la el DTO GetEmpleadoDTO
                CreateMap<Participante, GetParticipanteDTO>();
                //Establecemos el mappeo desde la entidad Empleado hacia el DTO EmpleadoDTOConPuestos
                //CreateMap<Participante, ParticipanteDTOconRifas>()
                //    .ForMember(participanteDTO => participanteDTO.Rifas, opciones => opciones.MapFrom(MapParticipanteDTORifas));
                //Establecemos el mappeo de PuestoCreacionDTO hacia nuestra Entidad Puesto
                //CreateMap<RifaCreacionDTO, Rifa>()
                //    .ForMember(rifa => rifa.ParticipanteRifa, opciones => opciones.MapFrom(MapParticipanteRifa));
                //Establecemos el mappeo de la Entidad Puesto hacia el DTO PuestoDTO
                CreateMap<RifaDTO, Rifa>();
                CreateMap<Rifa,GetRifaDTO>();
            CreateMap<Rifa, RifaDTOconPremios>();
            //.ForMember(rifaDTO => rifaDTO.Premios, opciones => opciones.MapFrom(MapRifaDTOPremios));
            //CreateMap<PremioCreacionDTO, Premio>()
            //    .ForMember(premio => premio.RifaPremio, opciones => opciones.MapFrom(MapRifaClase));
            //CreateMap<Premio, PremioDTO>();
            //CreateMap<Premio, PremioDTOconRifas>()
            //    .ForMember(premioDTO => premioDTO.Rifas, opciones => opciones.MapFrom(MapPremioDTORifas));
                //Establecemos el mappeo de la Entidad Puesto hacie el DTO PuestoDTOconEmpleados
                //CreateMap<Rifa, RifaDTOconParticipantes>()
                //    .ForMember(rifaDTO => rifaDTO.Participantes, opciones => opciones.MapFrom(MapRifaDTOParticipantes));
                //Establecemos el mappeo des PuestoPatchDTO hacia la entidad Puesto
                CreateMap<RifaPatchDTO, Rifa>().ReverseMap();
                //Establecemos el mappeo desde DepartamentoCreacionDTO hacia la Entidad Departamentos
               
                
            
            }
            //Se crea una lista PuestoDTO con los parametros empleado y getEmpleadoDTO
            //private List<PremioDTO> MapRifaDTOPremios(Rifa rifa, GetRifaDTO getRifaDTO)
            //{
            //    var result = new List<PremioDTO>();
            //    //Verificamos que no sea null
            //    if (rifa.RifaPremio == null) { return result; }
            //    //iteraciones
            //    foreach (var rifaPremio in rifa.RifaPremio)
            //    {
            //        result.Add(new RifaDTO()
            //        {
            //            Id = rifaPremio.PremioId,
            //            Nombre = rifaPremio.Premio.Nombre
            //        });
            //    }

            //    return result;
            //}

            //Se crean una lista de GetEmpleadoDTO
            private List<GetParticipanteDTO> MapRifaDTOParticipantes(Rifa rifa, RifaDTO rifaDTO)
            {

                var result = new List<GetParticipanteDTO>();
                //Buscamos si es null
                if (rifa.ParticipanteRifa == null)
                {
                    return result;
                }
                //iteraciones
                foreach (var participanterifa in rifa.ParticipanteRifa)
                {
                    result.Add(new GetParticipanteDTO()
                    {
                        Id = participanterifa.ParticipanteId,
                        Nombre = participanterifa.Participante.Nombre
                    });
                }

                return result;
            }

            //Se crea una lista de EmpleadoPuesto
            //private List<ParticipanteRifa> MapParticipanteRifa(RifaCreacionDTO rifaCreacionDTO, Rifa rifa)
            //{

            //    var resultado = new List<ParticipanteRifa>();
            //    //se verifica si es null o no
            //    if (rifaCreacionDTO.ParticipantesIds == null)
            //    {
            //        return resultado;
            //    }

            //    //iteraciones
            //    foreach (var participanteId in rifaCreacionDTO.ParticipantesIds)
            //    {
            //        resultado.Add(new ParticipanteRifa() { ParticipanteId = participanteId });
            //    }
            //    return resultado;
            //}
        }
    }
