using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlanningPoker.Entities;
using PlanningPoker.DTO_s;

namespace PlanningPoker.Controllers
{
    [ApiController]
    [Route("UsuariosController")]
    public class UsuariosController : ControllerBase
    {
        private readonly PlanningPokerDbContext context;
        private readonly IMapper mapper;

        public UsuariosController(PlanningPokerDbContext context, IMapper mapper) 
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> Post(UsuarioCreacionDTO usuarioCreacion)
        {
            var usuario = mapper.Map<Usuario>(usuarioCreacion);

            context.Add(usuario);
            await context.SaveChangesAsync();
            return  Ok();
        }
    }
}
