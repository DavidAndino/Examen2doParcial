using BaseDatos;
using Entidades;
using System.Windows.Forms;

namespace Examen2doParcial
{
    public partial class Login : Syncfusion.Windows.Forms.Office2010Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void aceptarButton_Click(object sender, System.EventArgs e)
        {

            //validando controles vacios
            if (string.IsNullOrEmpty(usuarioTextBox.Text))
            {
                errorProvider1.SetError(usuarioTextBox, "Ingrese el usuario");
                usuarioTextBox.Focus();
                return;
            }
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(claveTextBox.Text))
            {
                errorProvider1.SetError(claveTextBox, "Ingrese la contraseña");
                claveTextBox.Focus();
                return;
            }
            errorProvider1.Clear();

            //validando en la base datos
            LoginEntidad ingresa = new LoginEntidad(usuarioTextBox.Text, claveTextBox.Text);
            UsuarioDB usuarioDeDB = new UsuarioDB();
            Usuario usuario = new Usuario();

            usuario = usuarioDeDB.Autenticacion(ingresa);
            if (usuario != null)//validando que el usuario exista en la base de datos
            {
                if (usuario.Activo)//validando que dicho usuario este activo
                {
                    //enviando el id de usuario al textbox del ticket
                    System.Security.Principal.GenericIdentity idUsuario = new System.Security.Principal.GenericIdentity(usuario.Id);
                    //pasando el GenericIdentity al principal
                    System.Security.Principal.GenericPrincipal principal = new System.Security.Principal.GenericPrincipal(idUsuario, null);
                    //psando el principal al "CurrentPrincipal"
                    System.Threading.Thread.CurrentPrincipal = principal;

                    //mostrando formulario de menu
                    Menu formularioMenu = new Menu();
                    this.Hide();
                    formularioMenu.Show();
                }
                else//si el usuario no esta activo:
                {
                    MessageBox.Show("El usuario no está activo actualmente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else//si el usuario no esta en la base de datos
            {
                MessageBox.Show("El nombre o contraseña de usuario no son correctos, o no existen en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usuarioTextBox.Focus();
            }

        }

        private void salirButton_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void ocultarButton_Click(object sender, System.EventArgs e)
        {
            if (claveTextBox.PasswordChar == '*')
            {
                claveTextBox.PasswordChar = '\0';
                claveTextBox.Focus();
            }
            else
            {
                claveTextBox.PasswordChar = '*';
                claveTextBox.Focus();
            }
        }
    }
}
