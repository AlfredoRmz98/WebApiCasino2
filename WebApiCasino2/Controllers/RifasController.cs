using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCasino2.DTOs;
using WebApiCasino2.Entidades;

namespace WebApiCasino2.Controllers
{
    [ApiController]
    [Route("api/rifas")]
    public class RifasController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public RifasController(ApplicationDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.dbContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Rifa>>> GetAll()
        {
            return await dbContext.Rifas.ToListAsync();
        }
        [HttpPost]
        [ActionName(nameof(RifaCreacionDTO))]
        public async Task<ActionResult> Post (RifaCreacionDTO rifaCreacionDTO)
        {
            var rifa = mapper.Map<Rifa>(rifaCreacionDTO);
            dbContext.Add(rifa);
            await dbContext.SaveChangesAsync();

            var rifaDTO = mapper.Map<RifaDTO>(rifa);
            return CreatedAtRoute("obtenerRifa", new { id = rifa.Id }, rifaDTO);
        }

        [HttpPut]
        public async Task<ActionResult> Put(int id, RifaCreacionDTO rifaCreacionDTO)
        {
            var rifaDB = await dbContext.Rifas
                .Include(x => x.ParticipanteRifa)
                .FirstOrDefaultAsync(x => x.Id == id);

            if(rifaDB == null)
            {
                return NotFound();
            }

            rifaDB = mapper.Map(rifaCreacionDTO, rifaDB);
            await dbContext.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(int id)
            {
            var exist = await dbContext.Rifas.AnyAsync(x => x.Id == id);
            if (!exist)
            {
                return NotFound("La rifa no fue encontrada");
            }
            dbContext.Remove(new Rifa { Id = id });
            await dbContext.SaveChangesAsync();
            return Ok();
            }


    }
}
