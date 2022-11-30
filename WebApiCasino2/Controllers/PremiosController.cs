using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCasino2.DTOs;
using WebApiCasino2.Entidades;

namespace WebApiCasino2.Controllers
{
    [ApiController]
    [Route("api/premios")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "EsAdmin")]
    public class PremiosController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public PremiosController(ApplicationDbContext context, IMapper mapper)
        {
            this.dbContext = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<Premio>>> GetAll()
        {
            return await dbContext.Premios.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> Post(PremioCreacionDTO premioCreacionDTO)
        {
            var premio = mapper.Map<Premio>(premioCreacionDTO);
            dbContext.Premios.Add(premio);
            await dbContext.SaveChangesAsync();
            var premioDTO = mapper.Map<PremioDTO>(premio);
            return CreatedAtRoute("ObtenerPremio", new { id = premio.Id }, premioDTO);
        }
    }
}

    


