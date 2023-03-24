namespace Entidades
{
    public class ClienteEntidad
    {
        public string ID { get; set; }
        public string Nombre { get; set; }
        public ClienteEntidad()
        {

        }
        public ClienteEntidad(string iD, string nombre)
        {
            ID = iD;
            Nombre = nombre;
        }
    }
}
