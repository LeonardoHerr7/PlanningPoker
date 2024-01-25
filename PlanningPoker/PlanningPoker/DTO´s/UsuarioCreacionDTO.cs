namespace PlanningPoker.DTO_s
{
    public class UsuarioCreacionDTO
    {
        public string Nombre { get; set; } = null!;
        public string Coreeo { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public int IdRol { get; set; }

        public List<int> Rol { get; set; } = new List<int>();
    }
}
