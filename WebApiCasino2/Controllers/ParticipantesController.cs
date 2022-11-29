using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCasino2.Entidades;
using WebApiCasino2.Filtros.WebApiEmpleados.Filtros;
using WebApiCasino2.Services;

namespace WebApiCasino2.Controllers
{
    [ApiController]
    [Route("api/participantes")]
   // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class ParticipantesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IService service;
        private readonly ServiceTransient serviceTransient;
        private readonly ServiceScoped serviceScoped;
        private readonly ServiceSingleton serviceSingleton;
        private readonly ILogger<ParticipantesController> logger;
        private readonly IWebHostEnvironment env;

        public ParticipantesController(ApplicationDbContext context, IService service,
            ServiceTransient serviceTransient, ServiceScoped serviceScoped,
            ServiceSingleton serviceSingleton, ILogger<ParticipantesController> logger,
            IWebHostEnvironment env)
        {
            this.dbContext = context;
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
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Post([FromBody] Participante participante)
        {
            //Validar que no se ingrese el mismo empleado dos veces
            var existeParticipanteMismoNombre = await dbContext.Participantes.AnyAsync(x => x.Nombre == participante.Nombre);

            if (existeParticipanteMismoNombre)
            {
                return BadRequest("Ya existe un participante con el nombre");
            }
            dbContext.Add(participante);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
        //[HttpGet("listado")]
        //[AllowAnonymous]
        //public async Task<ActionResult<List<Participante>>> Get()
        //{
        //    throw new NotImplementedException();
        //    logger.LogInformation("Se obtiene el listado de alumnos");
        //    logger.LogWarning("Mensaje de prueba warning");
        //    service.EjecutarJob();
        //    return await dbContext.Participantes.Include(x => x.ParticipanteRifa).ToListAsync();
        //}
        [HttpPut]
        [AllowAnonymous]
        public async Task<ActionResult> Put(Participante participante, int id)
        {
            if (participante.Id == id)
            {
                return BadRequest("El id del empleado coincide con el establecido en la url.");
            }

            dbContext.Update(participante);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
