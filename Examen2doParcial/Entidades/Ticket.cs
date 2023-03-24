using System;

namespace Entidades
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreCliente { get; set; }
        public string TipoSoporte { get; set; }
        public string DescripcionSolicitud { get; set; }
        public string DescripcionRespuesta { get; set; }
        public Decimal Precio { get; set; }
        public Decimal ISV { get; set; }
        public Decimal Descuento { get; set; }
        public Decimal Total { get; set; }
        public bool Activo { get; set; }
        public string NumeroSerie { get; set; }
        public Ticket()
        {

        }

        public Ticket(int id, DateTime fecha, string nombreCliente, string tipoSoporte, string numeroSerie, string descripcionSolicitud, string descripcionRespuesta, decimal precio, decimal iSV, decimal descuento, decimal total, bool activo)
        {
            Id = id;
            Fecha = fecha;
            NombreCliente = nombreCliente;
            TipoSoporte = tipoSoporte;
            NumeroSerie = numeroSerie;
            DescripcionSolicitud = descripcionSolicitud;
            DescripcionRespuesta = descripcionRespuesta;
            Precio = precio;
            ISV = iSV;
            Descuento = descuento;
            Total = total;
            Activo = activo;
        }
    }
}
