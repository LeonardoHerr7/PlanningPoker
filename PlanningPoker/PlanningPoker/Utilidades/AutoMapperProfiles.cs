using AutoMapper;
using PlanningPoker.Entities;
using PlanningPoker.DTO_s;

namespace PlanningPoker.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<UsuarioCreacionDTO, Usuario>();
            CreateMap<RolCreacionDTO, Rol>();
            CreateMap<TipoEstimacionCreacionDTO, TipoEstimacion>();
        }

    }
}
