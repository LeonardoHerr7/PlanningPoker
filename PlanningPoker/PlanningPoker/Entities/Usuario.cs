using System;
using System.Collections.Generic;

namespace PlanningPoker.CarpetaDeSalida
{
    public partial class Usuario
    {
        public Usuario()
        {
            IdSesions = new HashSet<Sesion>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Correo { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public int IdRol { get; set; }

        public virtual Rol IdRolNavigation { get; set; } = null!;

        public virtual ICollection<Sesion> IdSesions { get; set; }
    }
}
