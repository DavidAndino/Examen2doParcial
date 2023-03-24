namespace Entidades
{
    public class LoginEntidad
    {
        public string usuarioId { get; set; }
        public string clave { get; set; }

        public LoginEntidad()
        {

        }

        public LoginEntidad(string usuarioId, string clave)
        {
            this.usuarioId = usuarioId;
            this.clave = clave;
        }
    }
}
