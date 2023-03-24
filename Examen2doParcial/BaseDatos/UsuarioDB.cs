using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text;

namespace BaseDatos
{
    public class UsuarioDB
    {
        string cadenaConexion = "server = localhost; user = root; database = sistemasoportetecnico; password = 223344";
        public string idUsuario = "";
        public Usuario traerUsuariosPorId(string id)
        {
            Usuario user = null;


            try
            {
                StringBuilder sqlUsuario = new StringBuilder();//armando sentencia Sql a traves de un objeto
                sqlUsuario.Append(" SELECT * FROM usuario WHERE IdUsuario = @IdUsuario ");//sentencia para traer registros de la tabla de la base de datos
                sqlUsuario.Append(" SELECT LAST_INSERT_ID(); ");
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))//pasando un objeto de la conexion hacia MySql
                {
                    conexion.Open();//abriendo conexion

                    using (MySqlCommand comando = new MySqlCommand(sqlUsuario.ToString(), conexion))
                    {
                        comando.CommandType = CommandType.Text;//*especificando el tipo de comando que se ejecutara

                        MySqlDataReader dr = comando.ExecuteReader();//trayendo los datos
                        //pasando a cada propiedad los datos que se guardan en el objeto "dr"
                        if (dr.Read())
                        {
                            user = new Usuario();//instanciando objeto
                            user.Id = id;
                            user.Nombre = dr["Nombre"].ToString();
                            user.contrasenia = dr["Contraseña"].ToString();
                            user.FechaCreacion = (DateTime)dr["FechaCreacion"];
                            user.Activo = Convert.ToBoolean(dr["Activo"]);
                            idUsuario = Convert.ToString(comando.ExecuteScalar());
                        }

                    }//esta sentencia de comando ejecuta la sentencia de sql
                }//esta sentencia ayuda a que, cuando termina la conexion con la DB, cerrar la conexion 
            }
            catch (Exception)
            {
            }

            return user;//se devuelve el objeto "user" de  la clase "Usuario", para validar que todos los datos sean correctos a la hora de ingresar a la DB
        }
        public Usuario Autenticacion(LoginEntidad ingresa)
        {
            Usuario usuario = null;
            try
            {
                StringBuilder sqlUsuario = new StringBuilder();
                sqlUsuario.Append(" SELECT * FROM usuario WHERE IdUsuario = @IdUsuario AND Contraseña = @Contraseña ");

                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();
                    using (MySqlCommand comando = new MySqlCommand(sqlUsuario.ToString(), conexion))
                    {
                        usuario = new Usuario();
                        comando.CommandType = System.Data.CommandType.Text;
                        comando.Parameters.Add("@IdUsuario", MySqlDbType.VarChar, 25).Value = ingresa.usuarioId;
                        comando.Parameters.Add("@Contraseña", MySqlDbType.VarChar, 45).Value = ingresa.clave;

                        MySqlDataReader capturador = comando.ExecuteReader();
                        if (capturador.Read())
                        {
                            usuario.Id = capturador["IdUsuario"].ToString();
                            usuario.Nombre = capturador["Nombre"].ToString();
                            usuario.contrasenia = capturador["Contraseña"].ToString();
                            if (capturador["FechaCreacion"].GetType() != typeof(DBNull))//no la fecha en el motor de base de datos es nula, no se ejecuta la siguiente linea:
                            {
                                usuario.FechaCreacion = Convert.ToDateTime(capturador["FechaCreacion"]);
                            }
                            usuario.Activo = Convert.ToBoolean(capturador["Activo"]);
                        }
                        else
                        {
                            usuario = null;//si el capturador no trae algo, el valor de usuario es null, y al intentar ingresar, mostrara un error
                        }
                    }
                }

            }
            catch (Exception)
            {
            }
            return usuario;
        }
    }
}
