using Entidades;
using MySql.Data.MySqlClient;
using System.Text;
namespace BaseDatos
{
    public class TicketDB
    {
        //creando cadena de conexion con la base de datos
        string cadenaConexion = "server = localhost; user = root; database = sistemasoportetecnico; password = 223344";

        public bool ticketGuardado(TicketEntidad boleto, string IdCliente)
        {
            bool insertado = false;

            try
            {
                //sentencias para la clase "TicketDB"
                StringBuilder sqlTicket = new StringBuilder();
                sqlTicket.Append(" INSERT INTO ticket (IdUsuario,  IdCliente, Fecha, TipoSoporte, NumeroSerie, DescripcionSolicitud, DescripcionRespuesta, Precio, Isv, Descuento, Total, Activo) ");
                sqlTicket.Append(" VALUES (@IdUsuario, @IdCliente, @Fecha, @TipoSoporte, @NumeroSerie, @DescripcionSolicitud, @DescripcionRespuesta, @Precio, @Isv, @Descuento, @Total, @Activo); ");


                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    MySqlTransaction transaccion = conexion.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
                    try
                    {
                        using (MySqlCommand comando = new MySqlCommand(sqlTicket.ToString(), conexion))
                        {

                            comando.CommandType = System.Data.CommandType.Text;//especificando tipo de comando
                            comando.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 10).Value = System.Threading.Thread.CurrentPrincipal.Identity.Name;//pasando llave foranea de la entidad Usuario
                            comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 13).Value = IdCliente;//pasando llave foranea de la entidad Cliente
                            comando.Parameters.Add("@Fecha", MySqlDbType.Date).Value = boleto.Fecha;
                            comando.Parameters.Add("@TipoSoporte", MySqlDbType.VarChar, 15).Value = boleto.TipoSoporte;
                            comando.Parameters.Add("@NumeroSerie", MySqlDbType.VarChar, 45).Value = boleto.NumeroSerie;
                            comando.Parameters.Add("@DescripcionSolicitud", MySqlDbType.VarChar, 150).Value = boleto.DescripcionSolicitud;
                            comando.Parameters.Add("@DescripcionRespuesta", MySqlDbType.VarChar, 150).Value = boleto.DescripcionRespuesta;
                            comando.Parameters.Add("@Precio", MySqlDbType.Decimal).Value = boleto.Precio;
                            comando.Parameters.Add("@Isv", MySqlDbType.Decimal).Value = boleto.ISV;
                            comando.Parameters.Add("@Descuento", MySqlDbType.Decimal).Value = boleto.Descuento;
                            comando.Parameters.Add("@Total", MySqlDbType.Decimal).Value = boleto.Total;
                            comando.Parameters.Add("@Activo", MySqlDbType.Bit).Value = boleto.Activo;
                            comando.ExecuteNonQuery();//se activa este comando porque no se devolvera algun registro, ya que se esta insertando
                            transaccion.Commit();//ejecutando la transaccion si todo sale bien
                            insertado = true;//cambiando valor que permite el guardado en la base de datos
                        }
                    }
                    catch (System.Exception)
                    {
                        insertado = false;
                        transaccion.Rollback();
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
