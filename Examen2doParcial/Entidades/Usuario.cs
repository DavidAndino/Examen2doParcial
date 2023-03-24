using System;

namespace Entidades
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string contrasenia { get; set; }
        public DateTime FechaCreacion { get; set; }//empezo a trabajar tal fecha
        public bool Activo { get; set; }

        public Usuario()
        {

        }

        public Usuario(string id, string nombre, string contrasenia, DateTime fechaCreacion, bool activo)
        {
            Id = id;
            Nombre = nombre;
            this.contrasenia = contrasenia;
            FechaCreacion = fechaCreacion;
            Activo = activo;
        }
    }
}
