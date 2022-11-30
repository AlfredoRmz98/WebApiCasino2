using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCasino2.DTOs;
using WebApiCasino2.Entidades;
using WebApiCasino2.Filtros.WebApiEmpleados.Filtros;
using WebApiCasino2.Services;

namespace WebApiCasino2.Controllers
{
    [ApiController]
    [Route("api/participantes")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class ParticipantesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IConfiguration configuration;
        private readonly IService service;
        private readonly ServiceTransient serviceTransient;
        private readonly ServiceScoped serviceScoped;
        private readonly ServiceSingleton serviceSingleton;
        private readonly ILogger<ParticipantesController> logger;
        private readonly IWebHostEnvironment env;

        public ParticipantesController(ApplicationDbContext context,IMapper mapper,IConfiguration configuration, IService service,
            ServiceTransient serviceTransient, ServiceScoped serviceScoped,
            ServiceSingleton serviceSingleton, ILogger<ParticipantesController> logger,
            IWebHostEnvironment env)
        {
            this.dbContext = context;
            this.mapper = mapper;
            this.configuration = configuration;
            this.service = service;
            this.serviceTransient = serviceTransient;
            this.serviceScoped = serviceScoped;
            this.serviceSingleton = serviceSingleton;
            this.logger = logger;
            this.env = env;
        }
        [HttpGet("GUID")]
        [AllowAnonymous]
        [ResponseCache(Duration = 10)]
        [ServiceFilter(typeof(FiltroDeAccion))]
        public ActionResult ObtenerGuid()
        {
            //throw new NotImplementedException();
            logger.LogInformation("Durante la ejecucion");
            return Ok(new
            {
                EmpleadosControllerTransient = serviceTransient.guid,
                ServiceA_Transient = service.GetTransient(),
                EmpleadosControllerScoped = serviceScoped.guid,
                ServiceA_Scoped = service.GetScoped(),
                EmpleadosControllerSingleton = serviceSingleton.guid,
                ServiceA_Singleton = service.GetSingleton()
            });
        }
        [HttpGet]
        public async Task<ActionResult<List<GetParticipanteDTO>>> Get()
        {
            var participantes = await dbContext.Participantes.ToListAsync();
            return mapper.Map<List<GetParticipanteDTO>>(participantes);
        }
        [HttpGet("{nombre}")]
        public async Task<ActionResult<List<GetParticipanteDTO>>> Get([FromRoute] string nombre)
        {
            var participantes = await dbContext.Participantes.Where(participanteDB => participanteDB.Nombre.Contains(nombre)).ToListAsync();
            if(participantes == null)
            {
                return BadRequest("No se encuentra registado el participante");
            }
            return mapper.Map<List<GetParticipanteDTO>>(participantes);
        }
        [HttpPost]
        public async Task<ActionResult> Post ([FromBody] ParticipanteDTO participanteDto)
        {
            var existeParticipanteMismoNombre = await dbContext.Participantes.AnyAsync(x => x.Nombre == participanteDto.Nombre);

            if(existeParticipanteMismoNombre)
            {
                return BadRequest($"Ya existe un participante con el nombre {participanteDto.Nombre}");
            }
            var participante = mapper.Map<Participante>(participanteDto);
            dbContext.Add(participante);
            await dbContext.SaveChangesAsync();

            var participanteDTO = mapper.Map<GetParticipanteDTO>(participante);
            return CreatedAtRoute("obtenerparticipante", new { id = participante.Id }, participanteDTO);
        }
        
        [HttpPut]
        public async Task<ActionResult> Put(ParticipanteDTO participanteCreacionDTO, int id)
        {
            var exist = await dbContext.Participantes.AnyAsync(x => x.Id == id);

            if(!exist)
            {
                return NotFound();
            }
            var participante = mapper.Map<Participante>(participanteCreacionDTO);
            participante.Id = id;

            dbContext.Update(participante);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
        {
            var exist = await dbContext.Participantes.AnyAsync(x => x.Id==id);
            if(!exist)
            {
                return NotFound("El participante no fue encontrado");
            }
            dbContext.Remove(new Participante()
            {
                Id = id
            });
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
