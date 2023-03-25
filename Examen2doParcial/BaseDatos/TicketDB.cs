using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
        public DataTable traerTickets()
        {
            DataTable dt = new DataTable();//instanciando objeto de esta clase
            try
            {
                StringBuilder sqlTicket = new StringBuilder();//armando sentencia Sql a traves un objeto
                sqlTicket.Append("SELECT * FROM ticket");//sentencia para traer todos los registros de la tabla Ticket de la base de datos

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))//pasando un objeto de la conexion hacia MySql
                {
                    conexion.Open();//abriendo conexion

                    using (MySqlCommand comando = new MySqlCommand(sqlTicket.ToString(), conexion))
                    {
                        comando.CommandType = CommandType.Text;//*especificando el tipo de comando que se ejecutara

                        MySqlDataReader dr = comando.ExecuteReader();//trayendo los datos
                        dt.Load(dr);//llenando el objeto de tipo "DataTable" con los registros almacenados en el objeto "dr" 
                    }//esta sentencia de comando ejecuta la sentencia de sql
                }//esta sentencia ayuda a que, cuando termina la conexion con la DB, se cierre la conexion
            }
            catch (System.Exception)
            {
            }

            return dt;
        }
        public bool ticketModificado(TicketEntidad boleto)
        {
            bool editado = false;

            try
            {
                StringBuilder sql = new StringBuilder();//armando sentencia Sql through un objeto
                sql.Append(" UPDATE ticket SET ");//sentencia para editar algun registro

                sql.Append(" Activo = @Activo ");//sentencias para editar solo el atributo de "Activo" en la DB

                sql.Append(" WHERE IdTicket = @IdTicket; ");//solo permitiendo que se edite un ticket por un Id especificado
                //sql.Append(" SELECT LAST_INSERT_ID(); ");

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))//pasando un objeto de la conexion hacia MySql
                {
                    conexion.Open();//abriendo conexion

                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), conexion))
                    {
                        comando.CommandType = System.Data.CommandType.Text;/*especificando el tipo de comando que se ejecutara
                                                                            en este caso es un comando de texto, pues ee el codigo varchar el que se ingresa*/
                        comando.Parameters.Add("@IdTicket", MySqlDbType.Int16).Value = boleto.Id;
                        comando.Parameters.Add("@Activo", MySqlDbType.Bit).Value = boleto.Activo;

                        comando.ExecuteNonQuery();//se va a ejecutar, pero no se devolvera algun registro
                        editado = true;

                    }//esta sentencia de comando ejecuta la sentencia de sql
                }//esta sentencia ayuda a que, cuando termina la conexion con la DB, cerrar la conexion automatically
            }
            catch (Exception)
            {
            }

            return editado;//se devuelve la variable "edited"
        }
    }
}
