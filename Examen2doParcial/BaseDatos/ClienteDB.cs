using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace BaseDatos
{
    public class ClienteDB
    {
        string cadenaConexion = "server = localhost; user = root; database = sistemasoportetecnico; password = 223344";
        public ClienteEntidad traerClientesPorID(string id)
        {
            ClienteEntidad cliente = null;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("SELECT * FROM cliente WHERE IdCliente = @IdCliente");//sentencia para traer registros de la identidad de la tabla de la base de datos

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();//abriendo conexion

                    using (MySqlCommand comando = new MySqlCommand(sql.ToString(), conexion))
                    {
                        comando.CommandType = CommandType.Text;//*especificando el tipo de comando que se ejecutara
                        comando.Parameters.Add("@IdCliente", MySqlDbType.VarChar, 13).Value = id;
                        MySqlDataReader dr = comando.ExecuteReader();//trayendo los datos
                        //pasando a cada propiedad los datos que se guardan en el objeto "dr"
                        if (dr.Read())
                        {
                            cliente = new ClienteEntidad();//instanciando objeto
                            cliente.ID = id;
                            cliente.Nombre = dr["Nombre"].ToString();
                        }

                    }//esta sentencia de comando ejecuta la sentencia de sql
                }//esta sentencia ayuda a que, cuando termina la conexion con la DB, cerrar la conexion automatically
            }
            catch (Exception)
            {
            }

            return cliente;//se devuelve el objeto "cliente" de  la clase "ClienteEntidad", para validar que todos los datos sean correctos a la hora de ingresar a la DB
        }
    }
}
