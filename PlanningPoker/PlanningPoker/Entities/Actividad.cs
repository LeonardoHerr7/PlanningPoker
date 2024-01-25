using System;
using System.Collections.Generic;

namespace PlanningPoker.Entities
{
    public partial class Actividad
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string? Descripcion { get; set; }
        public int? Ponderacion { get; set; }
        public int Estatus { get; set; }

        public virtual Historia IdHistoriaNavigation { get; set; } = null!;
    }
}
