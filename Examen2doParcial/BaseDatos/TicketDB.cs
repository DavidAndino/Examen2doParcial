using Entidades;
using MySql.Data.MySqlClient;
using System.Text;
namespace BaseDatos
{
    public class TicketDB
    {
        //creando cadena de conexion con la base de datos
        string cadenaConexion = "server = localhost; user = root; database = sistemasoportetecnico; password = 223344";

        public bool ticketGuardado(Ticket boleto)
        {
            bool insertado = false;

            try
            {
                StringBuilder sqlTicket = new StringBuilder();
                sqlTicket.Append(" INSERT INTO sistemasoportetecnico (Fecha,  Cliente, TipoSoporte, DescripcionSolicitud, DescripcionRespuesta, Precio, Total) ");
                sqlTicket.Append(" VALUES ( @Fecha,  @Cliente, @TipoSoporte, @DescripcionSolicitud, @DescripcionRespuesta, @Precio, @Total); ");

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    MySqlTransaction transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);

                    using (MySqlCommand comando = new MySqlCommand(sqlTicket.ToString(), conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;//especificando tipo de comando
                        comando.Parameters.Add("@Fecha", MySqlDbType.Date).Value = boleto.Fecha;
                        comando.Parameters.Add("@Cliente", MySqlDbType.VarChar, 25).Value = boleto.NombreCliente;
                        comando.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 15).Value = boleto.TipoSoporte;
                        comando.Parameters.Add("@NumeroSerie", MySqlDbType.VarChar, 45).Value = boleto.NumeroSerie;
                        comando.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 150).Value = boleto.DescripcionSolicitud;
                        comando.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 150).Value = boleto.DescripcionRespuesta;
                        comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = boleto.Precio;
                        comando.Parameters.Add("@Isv", MySqlDbType.Decimal).Value = boleto.ISV;
                        comando.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = boleto.Descuento;
                        comando.Parameters.Add("@Total", MySqlDbType.Decimal).Value = boleto.Total;
                        comando.Parameters.Add("@Activo", MySqlDbType.Bit).Value = boleto.Activo;
                        comando.ExecuteNonQuery();//se activa este comando porque no se devolvera algun registro, ya que se esta insertando
                        insertado = true;
                    }
                }
            }
            catch (System.Exception)
            {
            }
            return insertado;
        }
    }
}
