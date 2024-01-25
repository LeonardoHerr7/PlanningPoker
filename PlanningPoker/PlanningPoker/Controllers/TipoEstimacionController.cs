using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanningPoker.Entities;
using PlanningPoker.DTO_s;

namespace PlanningPoker.Controllers
{
    [ApiController]
    [Route("Tipo Estimacion Controller")]
    public class TipoEstimacionController : Controller
    {
        private readonly PlanningPokerDbContext context;
        private readonly IMapper mapper;

        public TipoEstimacionController(PlanningPokerDbContext context, IMapper mapper) 
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost("Agregar TipoEstimacion")]
        public async Task<ActionResult> Post (TipoEstimacionCreacionDTO tipoEstimacioncreacion)
        {
            var tipoEstimacion = mapper.Map<TipoEstimacion>(tipoEstimacioncreacion);

            context.Add(tipoEstimacion);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("Consultar General")]
        public async Task<ActionResult<IEnumerable<TipoEstimacion>>> Get()
        {
            return await context.TipoEstimacions.ToListAsync();
        }

        [HttpPut("Update: int")]
        public async Task<ActionResult> Put(int id, TipoEstimacionCreacionDTO tipoEstimacionCreacion)
        {
            var tipoEstimacion = mapper.Map<TipoEstimacion>(tipoEstimacionCreacion);
            tipoEstimacion.Id = id;

            context.Update(tipoEstimacion);
            await context.SaveChangesAsync();
            return Ok();
            
        }

        //[HttpDelete("Delete: int")]
        //public async Task<ActionResult> Delete(int id, TipoEstimacionCreacionDTO tipoEstimacionCreacion)
        //{
        //    var filasAlteradas = await context.TipoEstimacions.Where(te => te.Id = id).ex;

        //    if(filasAlteradas == 0)
        //    {
        //        return NotFound();
        //    }

        //    return Ok();
        //}
    }
}
