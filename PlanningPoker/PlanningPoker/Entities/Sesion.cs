using System;
using System.Collections.Generic;

namespace PlanningPoker.Entities
{
    public partial class Sesion
    {
        public Sesion()
        {
            Historia = new HashSet<Historia>();
            IdUsuarios = new HashSet<Usuario>();
        }

        public int Id { get; set; }
        public int IdEstimacion { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual TipoEstimacion IdEstimacionNavigation { get; set; } = null!;
        public virtual ICollection<Historia> Historia { get; set; }

        public virtual ICollection<Usuario> IdUsuarios { get; set; }
    }
}
