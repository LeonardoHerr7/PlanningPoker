using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlanningPoker.Entities;
using PlanningPoker.DTO_s;

namespace PlanningPoker.Controllers
{
    [ApiController]
    [Route("Roles Controller")]
    public class RolController: ControllerBase
    {
        private readonly PlanningPokerDbContext context;
        private readonly IMapper mapper;

        public RolController(PlanningPokerDbContext context, IMapper mapper) 
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost("Agregar")]
        public async Task<ActionResult> Post(RolCreacionDTO rolCreacion)
        {
            var rol = mapper.Map<Rol>(rolCreacion);

            context.Add(rol);
            await context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("consultar")]
        public async Task<ActionResult<IEnumerable<Rol>>> Get()
        {
            return await context.Rols.ToListAsync();
        }

        [HttpPut("id:int / Actualizar")]
        public async Task<ActionResult> Put(int id, RolCreacionDTO rolCreacion)
        {
            var rol = mapper.Map<Rol>(rolCreacion);
            rol.Id = id;
            context.Update(rol);
            await context.SaveChangesAsync();
            return Ok();
        }

        //[HttpDelete("id:int / Delete")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //    var filasAlteradas = await context.Rols.Where(g => g.Id == id).ex

        //    if(filasAlteradas == 0)
        //    {
        //        return NotFound();
        //    }

        //    return NoContent();

        //}
    }
}
