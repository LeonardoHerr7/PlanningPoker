using System;
using System.Collections.Generic;

namespace PlanningPoker.CarpetaDeSalida
{
    public partial class TipoEstimacion
    {
        public TipoEstimacion()
        {
            Sesions = new HashSet<Sesion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<Sesion> Sesions { get; set; }
    }
}
