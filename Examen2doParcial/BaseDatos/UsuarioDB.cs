using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Text;

namespace BaseDatos
{
    public class UsuarioDB
    {
        string cadenaConexion = "server = localhost; user = root; database = sistemasoportetecnico; password = 223344";
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
                            usuario.FechaCreacion = Convert.ToDateTime(capturador["FechaCreacion"].ToString());
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
