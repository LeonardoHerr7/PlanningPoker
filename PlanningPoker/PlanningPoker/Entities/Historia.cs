using System;
using System.Collections.Generic;

namespace PlanningPoker.Entities
{
    public partial class Historia
    {
        public Historia()
        {
            Actividads = new HashSet<Actividad>();
        }

        public int Id { get; set; }
        public int IdSesion { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }

        public virtual Sesion IdSesionNavigation { get; set; } = null!;
        public virtual ICollection<Actividad> Actividads { get; set; }
    }
}
